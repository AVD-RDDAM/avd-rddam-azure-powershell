### Example 1: Create a Azure Virtual Desktop ConnectionPolicy by name
```powershell
New-AzWvdConnectionPolicy -ResourceGroupName ResourceGroupName `
                            -Name ConnectionPolicyName `
                            -Location 'eastus' `
                            -AuthenticationContext 'C1, C2' `
                            -Description 'Description'
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ConnectionPolicyName Microsoft.DesktopVirtualization/connectionpolicies
```

This command creates a Azure Virtual Desktop ConnectionPolicy in a Resource Group.

