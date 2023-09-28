param([string] $filePath)
$env = @{}
#---------- Self Contained Resources ----------
# The following resources are created and removed within each test.
$envFile = 'env.json'
$null = $env.Add("SubscriptionId", (Get-AzContext).Subscription.id)
$null = $env.Add("TenantId", (Get-AzContext).TenantId)
$null = $env.Add("ResourceGroup", "alecbPowershellTests")
$null = $env.Add("Location", "westus2")
$null = $env.Add("HostPool", "HostPoolPowershellContained1")
$null = $env.Add("HostPool2", "HostPoolPowershellContained2")
$null = $env.Add("RemoteApplicationGroup", "ApplicationGroupPowershell2")
$null = $env.Add("DesktopApplicationGroup", "ApplicationGroupPowershell1")
$null = $env.Add("MSIXImagePath", "https://pwshtestsa.blob.core.windows.net/pwshcontainer/firefox")

#auto-set based on the values above, do not edit
$null = $env.Add("HostPoolArmPath", "/subscriptions/"+ $env.SubscriptionId + "/resourcegroups/"+ $env.ResourceGroup + "/providers/Microsoft.DesktopVirtualization/hostpools/"+ $env.HostPool)
$null = $env.Add("HostPoolArmPath2", "/subscriptions/"+ $env.SubscriptionId + "/resourcegroups/"+ $env.ResourceGroup + "/providers/Microsoft.DesktopVirtualization/hostpools/"+ $env.HostPool2)
$null = $env.Add("DesktopApplicationGroupPath", "/subscriptions/"+ $env.SubscriptionId + "/resourcegroups/"+ $env.ResourceGroup + "/providers/Microsoft.DesktopVirtualization/applicationgroups/" + $env.DesktopApplicationGroup)
$null = $env.Add("RemoteApplicationGroupPath", "/subscriptions/"+ $env.SubscriptionId + "/resourcegroups/"+ $env.ResourceGroup + "/providers/Microsoft.DesktopVirtualization/applicationgroups/" + $env.RemoteApplicationGroup)
    
#---------- Persistent Resources ----------
# The following resources are manually created and removed by the operator.
$null = $env.Add("ResourceGroupPersistent", "alecbPowershellTests")
$null = $env.Add("HostPoolPersistent", "alecbDesktopHP")
$null = $env.Add("HostPoolPersistent2", "alecbRemoteAppHP")
$null = $env.Add("HostPoolPersistentArmPath", "/subscriptions/"+ $env.SubscriptionId + "/resourcegroups/"+ $env.ResourceGroupPersistent + "/providers/Microsoft.DesktopVirtualization/hostpools/"+ $env.HostPoolPersistent)
$null = $env.Add("SessionHostName", "sh-0")
$null = $env.Add("SessionHostNameRemove", "sh-2")
$null = $env.Add("PersistentDesktopAppGroup", "alecbDesktopHP-DAG")
$null = $env.Add("PersistentRemoteAppGroup", "alecbRemoteAppHP-DAG")
# The context in which the tests are run will change the tenant and subscription ID when -record is run. 
# Currently the scaling tests need to be run in a context with @microsoft, while the other tests are run with a test account
# Modify the env.json manually after recording the necessary tests to get around this issue.

 # Due to a limitation on how the powershell tests are validated during the PR process,
# any "cross-module" calls (Az.Network or similar) cannot be ran in the test file.
# the following commands will set up non-persistent resources that will be cleaned up at
# the end of each test run.

#variables used for internal setup

#PrivateLink Workspace resources
Write-Host -ForegroundColor Green 'Creating Private Link resources required for testing...'
try {
    $workspace = New-AzWvdWorkspace -ResourceGroupName $env.ResourceGroup `
    -Location $env.Location `
    -Name $env.PvtLinkWS `
    -FriendlyName 'fri' `
    -ApplicationGroupReference $null `
    -Description 'des'

    $privateLinkServiceConnectionWS = New-AzPrivateLinkServiceConnection -Name $env.PrivateEndpointConnectionNameWS `
                                        -PrivateLinkServiceId $workspace.ID `
                                        -GroupId $env.PECGroupIdWorkspace

    $privateLinkServiceConnectionWS1 = New-AzPrivateLinkServiceConnection -Name $env.PrivateEndpointConnectionNameWS1 `
                                            -PrivateLinkServiceId $workspace.ID `
                                            -GroupId $env.PECGroupIdWorkspace

    $vnet = Get-AzVirtualNetwork -ResourceGroupName $env.ResourceGroup `
    -Name $env.VnetName

    New-AzPrivateEndpoint -ResourceGroupName $env.ResourceGroup `
    -Name $env.PrivateEndpointNameWS `
    -Location $env.Location `
    -Subnet $vnet.Subnets[0] `
    -PrivateLinkServiceConnection $privateLinkServiceConnectionWS `
    -Force

    New-AzPrivateEndpoint -ResourceGroupName $env.ResourceGroup `
    -Name $env.PrivateEndpointNameWS1 `
    -Location $env.Location `
    -Subnet $vnet.Subnets[0] `
    -PrivateLinkServiceConnection $privateLinkServiceConnectionWS1 `
    -Force

    #Private Link HostPool Resources
    $hostpool = New-AzWvdHostPool -SubscriptionId $env.SubscriptionId `
        -ResourceGroupName $env.ResourceGroup `
        -Name $env.PvtLinkHP `
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
        -Ring $null `
        -ValidationEnvironment:$false `
        -PreferredAppGroupType 'Desktop' `
        -StartVMOnConnect:$false

    $privateLinkServiceConnectionHP = New-AzPrivateLinkServiceConnection -Name $env.PrivateEndpointConnectionNameHP `
                                        -PrivateLinkServiceId $hostpool.ID `
                                        -GroupId $env.PECGroupIdHostPool

    $privateLinkServiceConnectionHP1 = New-AzPrivateLinkServiceConnection -Name $env.PrivateEndpointConnectionNameHP1 `
                                        -PrivateLinkServiceId $hostpool.ID `
                                        -GroupId $env.PECGroupIdHostPool

    $vnet = Get-AzVirtualNetwork -ResourceGroupName $env.ResourceGroup `
                                -Name $env.VnetName

    New-AzPrivateEndpoint -ResourceGroupName $env.ResourceGroup `
                            -Name $env.PrivateEndpointNameHP `
                            -Location $env.Location `
                            -Subnet $vnet.Subnets[0] `
                            -PrivateLinkServiceConnection $privateLinkServiceConnectionHP `
                            -Force

    New-AzPrivateEndpoint -ResourceGroupName $env.ResourceGroup `
                            -Name $env.PrivateEndpointNameHP1 `
                            -Location $env.Location `
                            -Subnet $vnet.Subnets[0] `
                            -PrivateLinkServiceConnection $privateLinkServiceConnectionHP1 `
                            -Force
}
catch {
    Write-Host -ForegroundColor Red 'Failed to create Private Link Workspace resources required for testing...'
    Write-Host -ForegroundColor Red $_.Exception.Message
}
set-content -Path "$filePath\test\$envFile" -Value (ConvertTo-Json $env)