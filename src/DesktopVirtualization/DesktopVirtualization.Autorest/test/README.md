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

The host pool tests cover the new `FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection` and `FirstPartyExtensionAutoUpdateTeamsMediaOptimization` parameters. Creation covers all four boolean combinations. Both `UpdateExpanded` and `UpdateViaIdentityExpanded` enable and disable each setting independently, verify the omitted setting is unchanged, and verify both settings survive an unrelated friendly-name update. Assertions inspect command responses and subsequent `Get-AzWvdHostPool` reads, including explicit false values. Each scenario creates and removes a dedicated standard host pool without modifying persistent host pools.

After adding these cases, record them from the module directory with `.\test-module.ps1 -Record -TestName New-AzWvdHostPool,Update-AzWvdHostPool`, then run the same command with `-Playback`. Existing recordings do not contain the new requests. These tests do not assume that passing null to a switch sends JSON null; nullability and the existing registration token type change are separate from the newly added parameters.

Session host configuration creation and update tests use separate automated host pools for managed and ephemeral disks. Managed cases send only `ManagedDiskType`; ephemeral cases send only `DiffDiskSettingOption Local` and `DiffDiskSettingPlacement TempDisk`, never both disk types. Update tests first create a configuration of the same disk type, rather than modifying the existing persistent pool. Each pool is removed after its case, including on assertion failure. The test environment persists separate `SHCCreateTestRunId` and `SHCUpdateTestRunId` identifiers; recording the corresponding command refreshes its identifier and recording unrelated commands preserves it. Live/record setup assigns the pool identity the required resource group and Key Vault roles and waits for propagation. Playback skips these role assignments and waits. The configured VM size and image must support the requested ephemeral disk placement and capacity.

Regenerate the failed disk recordings with `.\test-module.ps1 -Record -TestName New-AzWvdSessionHostConfiguration,Update-AzWvdSessionHostConfiguration`, then use `-Playback` to replay them. The old recordings contain requests with both disk types and cannot validate the corrected cases.