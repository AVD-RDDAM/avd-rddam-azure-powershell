if (($null -eq $TestName) -or ($TestName -contains 'New-AzWvdSessionHostConfiguration')) {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzWvdSessionHostConfiguration.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzWvdSessionHostConfiguration' {
    BeforeEach {
        $script:shcTestHostPool = $null
    }

    It '<Scenario>' -TestCases @(
        @{ Scenario = 'CreateExpanded'; DiskType = 'Managed' }
        @{ Scenario = 'CreateExpanded_EphemeralOSDisk'; DiskType = 'Ephemeral' }
    ) {
        param($Scenario, $DiskType)

        if ($env.SHCCreateTestRunId -notmatch '^[a-f0-9]{32}$') {
            throw 'Missing or invalid SHCCreateTestRunId. Record the creation tests again.'
        }
        $name = "shc-create-$($DiskType.ToLowerInvariant())-$($env.SHCCreateTestRunId)"
        $script:shcTestHostPool = New-SessionHostConfigurationTestHostPool -Environment $env -Name $name
        $parameters = Get-SessionHostConfigurationTestParameters -Environment $env -HostPoolName $name -DiskType $DiskType
        $created = New-AzWvdSessionHostConfiguration @parameters
        $saved = Get-AzWvdSessionHostConfiguration -SubscriptionId $env.SubscriptionId `
            -ResourceGroupName $env.ResourceGroup -HostPoolName $name -ErrorAction Stop
        foreach ($configuration in @($created, $saved)) {
            $configuration.VMNamePrefix | Should -Be 'createTest'
            if ($DiskType -eq 'Managed') {
                $configuration.ManagedDiskType | Should -Be 'Standard_LRS'
                $configuration.DiffDiskSettingOption | Should -BeNullOrEmpty
                $configuration.DiffDiskSettingPlacement | Should -BeNullOrEmpty
            }
            else {
                $configuration.ManagedDiskType | Should -BeNullOrEmpty
                $configuration.DiffDiskSettingOption | Should -Be 'Local'
                $configuration.DiffDiskSettingPlacement | Should -Be 'TempDisk'
            }
        }
    }

    AfterEach {
        if ($null -ne $script:shcTestHostPool) {
            Remove-AzWvdHostPool -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroup `
                -Name $script:shcTestHostPool.Name -Confirm:$false -ErrorAction Stop
            $script:shcTestHostPool = $null
        }
    }
}
