if(($null -eq $TestName) -or ($TestName -contains 'Get-AzWvdConnectionPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzWvdConnectionPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzWvdConnectionPolicy' {
    It 'Get' {
        try{
            $connectionPolicy = New-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy `
                                -Location $env.Location `
                                -AuthenticationContext 'C1, C2' `
                                -Description "connectionPolicyDescription"

            $connectionPolicy = Get-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy
                $connectionPolicy.AuthenticationContext | Should -Be 'C1, C2'
                $connectionPolicy.Description | Should -Be "connectionPolicyDescription"
        }
        finally{
            $connectionPolicy = Remove-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy
        }
    }

    It 'List' {
        try{
            $connectionPolicy = New-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy `
                                -Location $env.Location `
                                -AuthenticationContext 'C1, C2' `
                                -Description "connectionPolicyDescription"


            $connectionPolicy = New-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy2 `
                                -Location $env.Location `
                                -AuthenticationContext 'C1, C3' `
                                -Description "connectionPolicyDescription2"


            $connectionPolicys = Get-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup
                $connectionPolicys[0].AuthenticationContext | Should -Be 'C1, C2'
                $connectionPolicys[1].AuthenticationContext | Should -Be 'C1, C3'
        }
        finally{
            $connectionPolicy = Remove-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy

            $connectionPolicy = Remove-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy2
        }
    }

    It 'List Subscription Level' {
        try{
            $connectionPolicy = New-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy `
                                -Location $env.Location `
                                -AuthenticationContext 'C1, C2' `
                                -Description "connectionPolicyDescription2"


            $connectionPolicy = New-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy2 `
                                -Location $env.Location `
                                -AuthenticationContext 'C1, C3' `
                                -Description "connectionPolicyDescription2"


            $connectionPolicys = Get-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId
                                $connectionPolicys[0].AuthenticationContext | Should -Be 'C1, C2'
                                $connectionPolicys[1].AuthenticationContext | Should -Be 'C1, C3'
        }
        finally{
            $connectionPolicy = Remove-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                                -ResourceGroupName $env.ResourceGroup `
                                -Name $env.ConnectionPolicy

            $connectionPolicy = Remove-AzWvdConnectionPolicy -SubscriptionId $env.SubscriptionId `
                        -ResourceGroupName $env.ResourceGroup `
                        -Name $env.ConnectionPolicy2
        }
    }
}
