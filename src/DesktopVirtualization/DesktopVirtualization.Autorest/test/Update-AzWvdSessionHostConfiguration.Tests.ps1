if (($null -eq $TestName) -or ($TestName -contains 'Update-AzWvdSessionHostConfiguration')) {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzWvdSessionHostConfiguration.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzWvdSessionHostConfiguration' {
    BeforeEach {
        $script:shcTestHostPool = $null
    }

    It '<Scenario>' -TestCases @(
        @{ Scenario = 'UpdateExpanded'; DiskType = 'Managed' }
        @{ Scenario = 'UpdateExpanded_EphemeralOSDisk'; DiskType = 'Ephemeral' }
    ) {
        param($Scenario, $DiskType)

        if ($env.SHCUpdateTestRunId -notmatch '^[a-f0-9]{32}$') {
            throw 'Missing or invalid SHCUpdateTestRunId. Record the update tests again.'
        }
        $name = "shc-update-$($DiskType.ToLowerInvariant())-$($env.SHCUpdateTestRunId)"
        $script:shcTestHostPool = New-SessionHostConfigurationTestHostPool -Environment $env -Name $name
        $parameters = Get-SessionHostConfigurationTestParameters -Environment $env -HostPoolName $name -DiskType $DiskType
        $initial = New-AzWvdSessionHostConfiguration @parameters
        $initial.VMNamePrefix | Should -Be 'createTest'
        $updateParameters = @{
            SubscriptionId = $env.SubscriptionId
            ResourceGroupName = $env.ResourceGroup
            HostPoolName = $name
            VMNamePrefix = 'updateTest'
            MarketplaceInfoExactVersion = $env.MarketplaceImageVersion
            Confirm = $false
            ErrorAction = 'Stop'
        }
        if ($DiskType -eq 'Managed') {
            $updateParameters.ManagedDiskType = 'Premium_LRS'
        }
        else {
            $updateParameters.DiffDiskSettingOption = 'Local'
            $updateParameters.DiffDiskSettingPlacement = 'TempDisk'
        }
        $updated = Update-AzWvdSessionHostConfiguration @updateParameters
        $saved = Get-AzWvdSessionHostConfiguration -SubscriptionId $env.SubscriptionId `
            -ResourceGroupName $env.ResourceGroup -HostPoolName $name -ErrorAction Stop
        foreach ($configuration in @($updated, $saved)) {
            $configuration.VMNamePrefix | Should -Be 'updateTest'
            if ($DiskType -eq 'Managed') {
                $configuration.ManagedDiskType | Should -Be 'Premium_LRS'
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
