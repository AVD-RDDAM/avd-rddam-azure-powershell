$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzWvdHostPool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzWvdHostPool' {
    It 'FirstPartyExtensionAutoUpdate_Create_<Scenario>' -TestCases @(
        @{ Scenario = 'BothEnabled'; MultimediaRedirection = $true; TeamsOptimization = $true }
        @{ Scenario = 'BothDisabled'; MultimediaRedirection = $false; TeamsOptimization = $false }
        @{ Scenario = 'OnlyMultimedia'; MultimediaRedirection = $true; TeamsOptimization = $false }
        @{ Scenario = 'OnlyTeams'; MultimediaRedirection = $false; TeamsOptimization = $true }
    ) {
        param($Scenario, [bool]$MultimediaRedirection, [bool]$TeamsOptimization)

        $createdHostPool = $null
        $resourceParameters = @{
            SubscriptionId = $env.SubscriptionId
            ResourceGroupName = $env.ResourceGroup
            Name = "$($env.HostPool)-fp-create-$Scenario"
            ErrorAction = 'Stop'
        }
        try {
            $createdHostPool = New-AzWvdHostPool @resourceParameters `
                -Location $env.Location -HostPoolType 'Pooled' -LoadBalancerType 'DepthFirst' `
                -PreferredAppGroupType 'Desktop' -ManagementType 'Standard' `
                -FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection:$MultimediaRedirection `
                -FirstPartyExtensionAutoUpdateTeamsMediaOptimization:$TeamsOptimization

            foreach ($hostPool in @($createdHostPool, (Get-AzWvdHostPool @resourceParameters))) {
                $hostPool.Name | Should -Be $resourceParameters.Name
                $hostPool.FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection | Should -Be $MultimediaRedirection
                $hostPool.FirstPartyExtensionAutoUpdateTeamsMediaOptimization | Should -Be $TeamsOptimization
            }
        }
        finally {
            if ($null -ne $createdHostPool) {
                Remove-AzWvdHostPool @resourceParameters -Confirm:$false
            }
        }
    }

    It 'FullScenarioCreate' {
        try{
            $hostPool = New-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool `
                                -Location $env.Location `
                                -HostPoolType 'Pooled' `
                                -LoadBalancerType 'DepthFirst' `
                                -PreferredAppGroupType 'Desktop' `
                                -DesktopAppGroupName 'FullSenerioCreateAG' `
                                -WorkspaceName 'FullSenerioCreateWS' `
                                -ManagementType 'Standard'
        }
        finally{
            $applicationGroup = Remove-AzWvdApplicationGroup -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name 'FullSenerioCreateAG'

            $hostPool = Remove-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool

            $workspace = Remove-AzWvdWorkspace -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name 'FullSenerioCreateWS'
        }
    }

    It 'Create' {
        try{
            $hostPool = New-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool `
                                -Location $env.Location `
                                -HostPoolType 'Pooled' `
                                -LoadBalancerType 'DepthFirst' `
                                -RegistrationTokenOperation 'Update' `
                                -ExpirationTime $((get-date).ToUniversalTime().AddDays(1).ToString('yyyy-MM-ddTHH:mm:ss.fffffffZ')) `
                                -Description 'des' `
                                -FriendlyName 'fri' `
                                -MaxSessionLimit 5 `
                                -VMTemplate '{option1}' `
                                -CustomRdpProperty $null `
                                -ConditionalRdpProperty 'redirectclipboard:i:1:authcontext:c5' `
                                -Ring $null `
                                -ValidationEnvironment:$false `
                                -PreferredAppGroupType 'Desktop' `
                                -StartVMOnConnect:$false `
                                -ManagementType 'Standard' `
                                -AllowRdpShortPathWithPrivateLink 'Enabled' `
                                -PublicUdp 'Disabled' `
                                -RelayUdp 'Disabled'

                $hostPool.Name | Should -Be $env.HostPool
                $hostPool.Location | Should -Be $env.Location
                $hostPool.HostPoolType | Should -Be 'Pooled'              
                $hostPool.LoadBalancerType | Should -Be 'DepthFirst'
                $hostPool.RegistrationInfoRegistrationTokenOperation | Should -Be 'Update'
                $hostPool.Description | Should -Be 'des'
                $hostPool.FriendlyName | Should -Be 'fri'
                $hostPool.MaxSessionLimit | Should -Be 5
                $hostPool.VMTemplate | Should -Be '{option1}'
                # @todo not correct since it should be null need to look into it
                # $hostPool.CustomRdpProperty | Should -Be ""
                $hostPool.ConditionalRdpProperty | Should -Be 'redirectclipboard:i:1:authcontext:c5'
                $hostPool.Ring | Should -Be 1
                # @todo need to check this
                # $hostPool.ValidationEnvironment | Should -Be $false
                $hostPool.PreferredAppGroupType | Should -Be 'Desktop'
                $hostPool.StartVMOnConnect | Should -Be $false
                $hostPool.AllowRdpShortPathWithPrivateLink | Should -Be 'Enabled'
                $hostPool.PublicUdp | Should -Be 'Disabled'
                $hostPool.RelayUdp | Should -Be 'Disabled'

            $hostPool = Get-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                            -ResourceGroupName $env.ResourceGroup `
                            -Name $env.HostPool
                $hostPool.Name | Should -Be $env.HostPool
                $hostPool.Location | Should -Be $env.Location
                $hostPool.HostPoolType | Should -Be 'Pooled'              
                $hostPool.LoadBalancerType | Should -Be 'DepthFirst'
                $hostPool.RegistrationInfoRegistrationTokenOperation | Should -BeNullOrEmpty
                $hostPool.Description | Should -Be 'des'
                $hostPool.FriendlyName | Should -Be 'fri'
                $hostPool.MaxSessionLimit | Should -Be 5
                $hostPool.VMTemplate | Should -Be '{option1}'
                # @todo not correct since it should be null need to look into it
                # $hostPool.CustomRdpProperty | Should -Be ""
                $hostPool.ConditionalRdpProperty | Should -Be 'redirectclipboard:i:1:authcontext:c5'
                $hostPool.Ring | Should -Be 1
                # @todo need to check this
                # $hostPool.ValidationEnvironment | Should -Be $false
                $hostPool.PreferredAppGroupType | Should -Be 'Desktop'
                $hostPool.StartVMOnConnect | Should -Be $false
                $hostPool.AllowRdpShortPathWithPrivateLink | Should -Be 'Enabled'
                $hostPool.PublicUdp | Should -Be 'Disabled'
                $hostPool.RelayUdp | Should -Be 'Disabled'
        }
        finally{
                $hostPool = Remove-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool
        }
    }
}
