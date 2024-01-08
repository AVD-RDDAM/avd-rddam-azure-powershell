### Example 1: Update a Azure Virtual Desktop ConnectionPolicy by name
```powershell
Update-AzWvdConnectionPolicy -ResourceGroupName ResourceGroupName `
                            -Name ConnectionPolicyName `
                            -AuthenticationContext 'C1' `
                            -Description 'Description' 
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ConnectionPolicyName Microsoft.DesktopVirtualization/connectionpolicies
```

This command updates a Azure Virtual Desktop ConnectionPolicy in a Resource Group.

