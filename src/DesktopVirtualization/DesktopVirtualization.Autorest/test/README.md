# Test
This directory contains the [Pester](https://www.powershellgallery.com/packages/Pester) tests to run for the module. We use Pester as it is the unofficial standard for PowerShell unit testing. Test stubs for custom cmdlets (created in `..\custom`) will be generated into this folder when `build-module.ps1` is ran. These test stubs will fail automatically, to indicate that tests should be written for custom cmdlets.

## Info
- Modifiable: yes
- Generated: partial
- Committed: yes
- Packaged: no

## Details
We allow three testing modes: *live*, *record*, and *playback*. These can be selected using the `-Live`, `-Record`, and `-Playback` switches respectively on the `test-module.ps1` script. This script will run through any `.Tests.ps1` scripts in the `test` folder. If you choose the *record* mode, it will create a `.Recording.json` file of the REST calls between the client and server. Then, when you choose *playback* mode, it will use the `.Recording.json` file to mock the communication between server and client. The *live* mode runs the same as the *record* mode; however, it doesn't create the `.Recording.json` file.

## Purpose
Custom cmdlets generally encompass additional functionality not described in the REST specification, or combines functionality generated from the REST spec. To validate this functionality continues to operate as intended, creating tests that can be ran and re-ran against custom cmdlets is part of the framework.

## Usage
To execute tests, run the `test-module.ps1`. To write tests, [this example](https://github.com/pester/Pester/blob/8b9cf4248315e44f1ac6673be149f7e0d7f10466/Examples/Planets/Get-Planet.Tests.ps1#L1) from the Pester repository is very useful for getting started.

## September 2026 Preview Contract Smoke

`New-AzWvdSessionHostConfiguration.Tests.ps1` includes opt-in `SeptemberPreviewNvmeCrud_<ManagedDiskType>` cases for `2026-09-01-preview`. They cover create, read, PATCH, readback, and list with `NvmeDisk` for `Standard_LRS`, `StandardSSD_LRS`, and `Premium_LRS`. Existing non-ephemeral and `TempDisk` cases remain as regression coverage.

1. Generate and build the Preview module from an approved, immutable September spec commit. April cmdlets and recordings do not validate September.
2. Obtain approval for the subscription, isolated test resource group, location, and writes before Live or Record. The existing fixture creates an Automated HostPool with a system-assigned identity and grants roles on the test resource group and configured Key Vault. Resource Contributor permission alone is insufficient: the caller must also be allowed to create those role assignments.
3. In the selected environment configuration, set `Enable20260901PreviewSmoke` to the JSON boolean `true` and `NvmeVmSize` to a compatible NVMe ephemeral OS disk size. Keep subnet, image and Key Vault secret URI settings valid for that size and location. Do not use a persistent HostPool for `HostPool`.
4. Select `New-AzWvdSessionHostConfiguration` with the module test runner. Record the new cases, then run Playback with the same opt-in setting. A skipped case or an authorization failure is not a successful smoke test. Do not fabricate recordings.

The cases reuse the Create suite's owned HostPool, not the persistent Update fixture. Its `AfterAll` deletes the parent HostPool; SessionHostConfiguration has no standalone DELETE operation. These Pester cases do not provision VMs or perform physical NVMe placement acceptance. A separate Compute VM CRUD run does not replace SHC Live/Record or feature-team signoff.

The request guard checks the September API version before the recording pipeline and leaves service-provided asynchronous polling URLs intact. List is invoked through the loaded private module's exported command metadata because the public Get wrapper has identical Get and List parameter sets and defaults to Get. This checks the list wire operation, not a distinct public list command.

These tests do not override a generated API version. Direct PowerShell REST calls can exercise an explicit API version before generation, but are separate from generated-cmdlet compatibility tests.