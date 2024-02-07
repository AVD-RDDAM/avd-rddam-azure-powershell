$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzWvdSessionHost.Recording.json'
$currentPath = $PSScriptRoot
$sessionHostPath = $env.HostPoolPersistent + "/userSess-sh-0"
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzWvdSessionHost' {
    It 'Get' {
        $sessionHost = Get-AzWvdSessionHost -SubscriptionId $env.SubscriptionId `
                            -ResourceGroupName $env.ResourceGroupPersistent `
                            -HostPoolName $env.HostPoolPersistent `
                            -Name $env.SessionHostName
            $sessionHost.Name | Should -Be $sessionHostPath
    }

    It 'List' {
        $sessionHosts = Get-AzWvdSessionHost -SubscriptionId $env.SubscriptionId `
                            -ResourceGroupName $env.ResourceGroupPersistent `
                            -HostPoolName $env.HostPoolPersistent
<<<<<<< HEAD
<<<<<<< HEAD:src/DesktopVirtualization/test/Get-AzWvdSessionHost.Tests.ps1
        $sessionHosts.Count | Should -Be 4
=======
        $sessionHosts.Count | Should -Be 2
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654:src/DesktopVirtualization/DesktopVirtualization.Autorest/test/Get-AzWvdSessionHost.Tests.ps1
=======
        $sessionHosts.Count | Should -Be 2
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654
    }
}
