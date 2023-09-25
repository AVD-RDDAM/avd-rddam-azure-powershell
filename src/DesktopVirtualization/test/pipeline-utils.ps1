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

set-content -Path "$filePath\test\$envFile" -Value (ConvertTo-Json $env)