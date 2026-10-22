$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzWvdHostPool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-AzWvdHostPool' {
    It 'FirstPartyExtensionAutoUpdate_<ParameterSet>_<Scenario>' -TestCases @(
        @{ ParameterSet = 'UpdateExpanded'; Scenario = 'Enable'; InitialState = $false }
        @{ ParameterSet = 'UpdateExpanded'; Scenario = 'Disable'; InitialState = $true }
        @{ ParameterSet = 'UpdateViaIdentityExpanded'; Scenario = 'Enable'; InitialState = $false }
        @{ ParameterSet = 'UpdateViaIdentityExpanded'; Scenario = 'Disable'; InitialState = $true }
    ) {
        param($ParameterSet, $Scenario, [bool]$InitialState)

        $createdHostPool = $null
        $targetState = -not $InitialState
        $route = if ($ParameterSet -eq 'UpdateViaIdentityExpanded') { 'identity' } else { 'name' }
        $resourceParameters = @{
            SubscriptionId = $env.SubscriptionId
            ResourceGroupName = $env.ResourceGroup
            Name = "$($env.HostPool)-fp-update-$route-$Scenario"
            ErrorAction = 'Stop'
        }
        try {
            $createdHostPool = New-AzWvdHostPool @resourceParameters `
                -Location $env.Location -HostPoolType 'Pooled' -LoadBalancerType 'DepthFirst' `
                -PreferredAppGroupType 'Desktop' -ManagementType 'Standard' `
                -FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection:$InitialState `
                -FirstPartyExtensionAutoUpdateTeamsMediaOptimization:$InitialState

            foreach ($hostPool in @($createdHostPool, (Get-AzWvdHostPool @resourceParameters))) {
                $hostPool.FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection | Should -Be $InitialState
                $hostPool.FirstPartyExtensionAutoUpdateTeamsMediaOptimization | Should -Be $InitialState
            }

            $updateParameters = @{ Confirm = $false; ErrorAction = 'Stop' }
            if ($ParameterSet -eq 'UpdateViaIdentityExpanded') {
                $updateParameters.InputObject = @{ Id = $createdHostPool.Id }
            }
            else {
                $updateParameters.SubscriptionId = $env.SubscriptionId
                $updateParameters.ResourceGroupName = $env.ResourceGroup
                $updateParameters.Name = $createdHostPool.Name
            }

            $updatedHostPool = Update-AzWvdHostPool @updateParameters `
                -FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection:$targetState
            foreach ($hostPool in @($updatedHostPool, (Get-AzWvdHostPool @resourceParameters))) {
                $hostPool.FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection | Should -Be $targetState
                $hostPool.FirstPartyExtensionAutoUpdateTeamsMediaOptimization | Should -Be $InitialState
            }

            $updatedHostPool = Update-AzWvdHostPool @updateParameters `
                -FirstPartyExtensionAutoUpdateTeamsMediaOptimization:$targetState
            foreach ($hostPool in @($updatedHostPool, (Get-AzWvdHostPool @resourceParameters))) {
                $hostPool.FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection | Should -Be $targetState
                $hostPool.FirstPartyExtensionAutoUpdateTeamsMediaOptimization | Should -Be $targetState
            }

            $updatedHostPool = Update-AzWvdHostPool @updateParameters -FriendlyName "fp-$Scenario"
            foreach ($hostPool in @($updatedHostPool, (Get-AzWvdHostPool @resourceParameters))) {
                $hostPool.FriendlyName | Should -Be "fp-$Scenario"
                $hostPool.FirstPartyExtensionAutoUpdateMicrosoftMultimediaRedirection | Should -Be $targetState
                $hostPool.FirstPartyExtensionAutoUpdateTeamsMediaOptimization | Should -Be $targetState
            }
        }
        finally {
            if ($null -ne $createdHostPool) {
                Remove-AzWvdHostPool @resourceParameters -Confirm:$false
            }
        }
    }

    It 'Update' {
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
                                -PreferredAppGroupType 'RailApplications' `
                                -StartVMOnConnect:$false `
                                -ManagementType 'Standard'
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
                $hostPool.PreferredAppGroupType | Should -Be 'RailApplications'
                $hostPool.StartVMOnConnect | Should -Be $false

            $hostPool = Update-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool `
                                -LoadBalancerType 'BreadthFirst' `
                                -Description 'des2' `
                                -FriendlyName 'fri2' `
                                -MaxSessionLimit 6 `
                                -VMTemplate '{option2}' `
                                -CustomRdpProperty $null `
                                -ConditionalRdpProperty 'drivestoredirect:s:*:authcontext:c30' `
                                -Ring $null `
                                -ValidationEnvironment:$false `
                                -PreferredAppGroupType 'Desktop' `
                                -StartVMOnConnect:$false
                $hostPool.Name | Should -Be $env.HostPool
                $hostPool.Location | Should -Be $env.Location
                $hostPool.HostPoolType | Should -Be 'Pooled'              
                $hostPool.LoadBalancerType | Should -Be 'BreadthFirst'
                $hostPool.Description | Should -Be 'des2'
                $hostPool.FriendlyName | Should -Be 'fri2'
                $hostPool.MaxSessionLimit | Should -Be 6
                $hostPool.VMTemplate | Should -Be '{option2}'
                # @todo not correct since it should be null need to look into it
                # $hostPool.CustomRdpProperty | Should -Be ""
                $hostPool.ConditionalRdpProperty | Should -Be 'drivestoredirect:s:*:authcontext:c30'
                $hostPool.Ring | Should -Be 1
                # @todo need to check this
                # $hostPool.ValidationEnvironment | Should -Be $false3
                $hostPool.PreferredAppGroupType | Should -Be 'Desktop'
                $hostPool.StartVMOnConnect | Should -Be $false

            $hostPool = Get-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool
                $hostPool.Name | Should -Be $env.HostPool
                $hostPool.Location | Should -Be $env.Location
                $hostPool.HostPoolType | Should -Be 'Pooled'              
                $hostPool.LoadBalancerType | Should -Be 'BreadthFirst'
                $hostPool.Description | Should -Be 'des2'
                $hostPool.FriendlyName | Should -Be 'fri2'
                $hostPool.MaxSessionLimit | Should -Be 6
                $hostPool.VMTemplate | Should -Be '{option2}'
                # @todo not correct since it should be null need to look into it
                # $hostPool.CustomRdpProperty | Should -Be ""
                $hostPool.ConditionalRdpProperty | Should -Be 'drivestoredirect:s:*:authcontext:c30'
                $hostPool.Ring | Should -Be 1
                # @todo need to check this
                # $hostPool.ValidationEnvironment | Should -Be $false
                $hostPool.PreferredAppGroupType | Should -Be 'Desktop'
                $hostPool.StartVMOnConnect | Should -Be $false
        }
        finally{
            $hostPool = Remove-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.HostPool
        }
    }
}
