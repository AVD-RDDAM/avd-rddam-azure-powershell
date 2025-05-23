---
external help file: Microsoft.Azure.PowerShell.Cmdlets.NetAppFiles.dll-Help.xml
Module Name: Az.NetAppFiles
online version: https://learn.microsoft.com/powershell/module/az.netappfiles/get-aznetappfilessnapshotpolicy
schema: 2.0.0
---

# Get-AzNetAppFilesSnapshotPolicy

## SYNOPSIS
Gets details of an Azure NetApp Files (ANF) snapshot policy.

## SYNTAX

### ByFieldsParameterSet (Default)
```
Get-AzNetAppFilesSnapshotPolicy -ResourceGroupName <String> -AccountName <String> [-Name <String>]
 [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ByParentObjectParameterSet
```
Get-AzNetAppFilesSnapshotPolicy [-Name <String>] -AccountObject <PSNetAppFilesAccount>
 [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ByResourceIdParameterSet
```
Get-AzNetAppFilesSnapshotPolicy -ResourceId <String> [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzNetAppFilesSnapshotPolicy** cmdlet gets details of an ANF snapshot policy.

## EXAMPLES

### Example 1
```powershell
Get-AzNetAppFilesSnapshotPolicy -ResourceGroupName "MyRG" -AccountName "MyAnfAccount" -Name "MySnapshotPolicy"
```

This command gets the backup policy named "MyBackupPolicy" for account "MyAnfAccount".

## PARAMETERS

### -AccountName
The name of the ANF account

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountObject
The Account for the new Snapshot Policy object

```yaml
Type: Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesAccount
Parameter Sets: ByParentObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the ANF snapshot policy

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet, ByParentObjectParameterSet
Aliases: SnapshotPolicyName

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The resource group of the ANF account

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
The resource id of the ANF Snapshot Policy

```yaml
Type: System.String
Parameter Sets: ByResourceIdParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

### Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesAccount

## OUTPUTS

### Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesSnapshotPolicy

## NOTES

## RELATED LINKS

[New-AzNetAppFilesSnapshotPolicy](./New-AzNetAppFilesSnapshotPolicy.md)
[Update-AzNetAppFilesSnapshotPolicy](./Update-AzNetAppFilesSnapshotPolicy.md)
[Remove-AzNetAppFilesSnapshotPolicy](./Remove-AzNetAppFilesSnapshotPolicy.md)
[Set-AzNetAppFilesSnapshotPolicy](./Set-AzNetAppFilesSnapshotPolicy.md)
[Get-AzNetAppFilesSnapshot](./Get-AzNetAppFilesSnapshot.md)
[New-AzNetAppFilesSnapshot](./New-AzNetAppFilesSnapshot.md)
[Remove-AzNetAppFilesSnapshot](./Remove-AzNetAppFilesSnapshot.md)
[Get-AzNetAppFilesVolume](./Get-AzNetAppFilesVolume.md)
[New-AzNetAppFilesVolume](./New-AzNetAppFilesVolume.md)
[Update-AzNetAppFilesVolume](./Update-AzNetAppFilesVolume.md)
[Remove-AzNetAppFilesVolume](./Remove-AzNetAppFilesVolume.md)
