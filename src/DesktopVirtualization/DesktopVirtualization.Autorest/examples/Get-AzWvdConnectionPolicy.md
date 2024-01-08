### Example 1: Get a Azure Virtual Desktop ConnectionPolicy by name

```powershell
Get-AzWvdConnectionPolicy -ResourceGroupName ResourceGroupName -Name ConnectionPolicyName
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ConnectionPolicyName Microsoft.DesktopVirtualization/connectionpolicies
```

This command gets a Azure Virtual Desktop ConnectionPolicy in a Resource Group.

### Example 2: List Azure Virtual Desktop ConnectionPolicies

```powershell
Get-AzWvdConnectionPolicy -ResourceGroupName ResourceGroupName
```

```output
Location   Name          Type
--------   ----          ----
eastus     ConnectionPolicyName1 Microsoft.DesktopVirtualization/connectionpolicies
eastus     ConnectionPolicyName2 Microsoft.DesktopVirtualization/connectionpolicies
```

This command lists a Azure Virtual Desktop ConnectionPolicys in a Resource Group.

### Example 2: List Azure Virtual Desktop ConnectionPolicies by subscription

```powershell
Get-AzWvdConnectionPolicy 
```

```output
Location   Name          Type
--------   ----          ----
eastus     ConnectionPolicyName1 Microsoft.DesktopVirtualization/connectionpolicies
eastus     ConnectionPolicyName2 Microsoft.DesktopVirtualization/connectionpolicies
```

This command lists a Azure Virtual Desktop ConnectionPolicys in a Resource Group.

