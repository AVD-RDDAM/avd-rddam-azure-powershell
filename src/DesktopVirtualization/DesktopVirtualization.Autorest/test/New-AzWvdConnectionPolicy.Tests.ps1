if(($null -eq $TestName) -or ($TestName -contains 'New-AzWvdConnectionPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzWvdConnectionPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzWvdConnectionPolicy' {
    It 'CreateExpanded' {
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
}
