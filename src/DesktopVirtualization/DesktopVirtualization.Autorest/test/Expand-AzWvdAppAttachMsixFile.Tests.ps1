if(($null -eq $TestName) -or ($TestName -contains 'Expand-AzWvdAppAttachMsixFile'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Expand-AzWvdAppAttachMsixFile.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Expand-AzWvdAppAttachMsixFile' {
    $appAttachPackageName = 'aatestpkg'
    $outputFileSharePath = '\\liweiavdtestsa.file.core.windows.net\avdtestfs\Apps\VHDX\XmlNotepad\XmlNotepad-expanded.vhdx'

    function New-ExpandMsixFileRequestBody {
        $body = [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.ExpandMsixFileRequest]::new()
        $body.HostpoolArmPath = $env.HostPoolPersistentArmPath
        $body.MsixFileShare = '\\liweiavdtestsa.file.core.windows.net\avdtestfs\Apps\MSIX'
        $body.MsixUncPath = [System.Collections.Generic.List[string]]::new()
        $body.MsixUncPath.Add($env.MSIXImagePath)
        $body.OutputFileSharePath = [System.Collections.Generic.List[string]]::new()
        $body.OutputFileSharePath.Add($outputFileSharePath)
        $body.MsixPackageSource = 'CustomerInput'
        $body.OutputFileType = 'VHDX'

        return $body
    }

    function New-ExpandMsixFileRequestJson {
        return @{
            properties = @{
                hostpoolArmPath = $env.HostPoolPersistentArmPath
                msixFileShare = '\\liweiavdtestsa.file.core.windows.net\avdtestfs\Apps\MSIX'
                msixUncPath = @($env.MSIXImagePath)
                outputFileSharePath = @($outputFileSharePath)
                msixPackageSource = 'CustomerInput'
                outputFileType = 'VHDX'
            }
        } | ConvertTo-Json -Depth 5
    }

    function New-AppAttachPackageIdentity {
        $identity = [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.DesktopVirtualizationIdentity]::new()
        $identity.SubscriptionId = $env.SubscriptionId
        $identity.ResourceGroupName = $env.ResourceGroupPersistent
        $identity.AppAttachPackageName = $appAttachPackageName
        $identity.Id = "/subscriptions/$($env.SubscriptionId)/resourceGroups/$($env.ResourceGroupPersistent)/providers/Microsoft.DesktopVirtualization/appAttachPackages/$appAttachPackageName"

        return $identity
    }

    function Assert-ExpandMsixFileResult {
        param($Result)

        $Result | Should -Not -Be $null
        $Result.Success.Count | Should -Be 1
        $Result.Success[0] | Should -Be $outputFileSharePath
        $Result.Failure.Count | Should -Be 0
    }

    It 'ExpandExpanded' {
        $result = Expand-AzWvdAppAttachMsixFile -AppAttachPackageName $appAttachPackageName `
            -ResourceGroupName $env.ResourceGroupPersistent `
            -SubscriptionId $env.SubscriptionId `
            -HostpoolArmPath $env.HostPoolPersistentArmPath `
            -MsixFileShare '\\liweiavdtestsa.file.core.windows.net\avdtestfs\Apps\MSIX' `
            -MsixUncPath $env.MSIXImagePath `
            -OutputFileSharePath $outputFileSharePath `
            -MsixPackageSource 'CustomerInput' `
            -OutputFileType 'VHDX'

        Assert-ExpandMsixFileResult $result
    }

    It 'ExpandViaJsonString' {
        $result = Expand-AzWvdAppAttachMsixFile -AppAttachPackageName $appAttachPackageName `
            -ResourceGroupName $env.ResourceGroupPersistent `
            -SubscriptionId $env.SubscriptionId `
            -JsonString (New-ExpandMsixFileRequestJson)

        Assert-ExpandMsixFileResult $result
    }

    It 'ExpandViaJsonFilePath' {
        $jsonFilePath = Join-Path $TestDrive 'expand-msix-file-request.json'
        New-ExpandMsixFileRequestJson | Set-Content -Path $jsonFilePath

        $result = Expand-AzWvdAppAttachMsixFile -AppAttachPackageName $appAttachPackageName `
            -ResourceGroupName $env.ResourceGroupPersistent `
            -SubscriptionId $env.SubscriptionId `
            -JsonFilePath $jsonFilePath

        Assert-ExpandMsixFileResult $result
    }

    It 'Expand' {
        $result = Expand-AzWvdAppAttachMsixFile -AppAttachPackageName $appAttachPackageName `
            -ResourceGroupName $env.ResourceGroupPersistent `
            -SubscriptionId $env.SubscriptionId `
            -Body (New-ExpandMsixFileRequestBody)

        Assert-ExpandMsixFileResult $result
    }

    It 'ExpandViaIdentityExpanded' {
        $result = Expand-AzWvdAppAttachMsixFile -InputObject (New-AppAttachPackageIdentity) `
            -HostpoolArmPath $env.HostPoolPersistentArmPath `
            -MsixFileShare '\\liweiavdtestsa.file.core.windows.net\avdtestfs\Apps\MSIX' `
            -MsixUncPath $env.MSIXImagePath `
            -OutputFileSharePath $outputFileSharePath `
            -MsixPackageSource 'CustomerInput' `
            -OutputFileType 'VHDX'

        Assert-ExpandMsixFileResult $result
    }

    It 'ExpandViaIdentity' {
        $result = Expand-AzWvdAppAttachMsixFile -InputObject (New-AppAttachPackageIdentity) `
            -Body (New-ExpandMsixFileRequestBody)

        Assert-ExpandMsixFileResult $result
    }
}
