---
external help file:
Module Name: Az.App
online version: https://learn.microsoft.com/powershell/module/az.app/get-azcontainerappmanagedenvdapr
schema: 2.0.0
---

# Get-AzContainerAppManagedEnvDapr

## SYNOPSIS
Get a dapr component.

## SYNTAX

### List (Default)
```
Get-AzContainerAppManagedEnvDapr -EnvName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzContainerAppManagedEnvDapr -DaprName <String> -EnvName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzContainerAppManagedEnvDapr -InputObject <IAppIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentityManagedEnvironment
```
Get-AzContainerAppManagedEnvDapr -DaprName <String> -ManagedEnvironmentInputObject <IAppIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get a dapr component.

## EXAMPLES

### Example 1: List dapr component.
```powershell
Get-AzContainerAppManagedEnvDapr -EnvName azps-env -ResourceGroupName azpstest_gp
```

```output
Name       ComponentType        IgnoreError InitTimeout ResourceGroupName Version
----       -------------        ----------- ----------- ----------------- -------
azps-dapr  state.azure.cosmosdb False       50s         azpstest_gp       v1
azps-dapr1 state.azure.cosmosdb True        50s         azpstest_gp       v1
```

List dapr component.

### Example 2: Get a dapr component.
```powershell
Get-AzContainerAppManagedEnvDapr -EnvName azps-env -ResourceGroupName azpstest_gp -DaprName azps-dapr1
```

```output
Name       ComponentType        IgnoreError InitTimeout ResourceGroupName Version
----       -------------        ----------- ----------- ----------------- -------
azps-dapr1 state.azure.cosmosdb True        50s         azpstest_gp       v1
```

Get a dapr component.

## PARAMETERS

### -DaprName
Name of the Dapr Component.

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentityManagedEnvironment
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnvName
Name of the Managed Environment.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedEnvironmentInputObject
Identity Parameter
To construct, see NOTES section for MANAGEDENVIRONMENTINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity
Parameter Sets: GetViaIdentityManagedEnvironment
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprComponent

## NOTES

## RELATED LINKS

