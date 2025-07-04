---
external help file:
Module Name: Az.Migrate
online version: https://learn.microsoft.com/powershell/module/az.migrate/new-azmigratediskmapping
schema: 2.0.0
---

# New-AzMigrateDiskMapping

## SYNOPSIS
Creates a new disk mapping

## SYNTAX

```
New-AzMigrateDiskMapping -DiskID <String> -DiskType <String> -IsOSDisk <String>
 [-DiskEncryptionSetID <String>] [<CommonParameters>]
```

## DESCRIPTION
The New-AzMigrateDiskMapping cmdlet creates a mapping of the source disk attached to the server to be migrated

## EXAMPLES

### Example 1: Make Standard disks
```powershell
New-AzMigrateDiskMapping -DiskID a -DiskType Standard_LRS -IsOSDisk 'true'
```

```output
DiskEncryptionSetId DiskId DiskType     IsOSDisk LogStorageAccountId LogStorageAccountSasSecretName  
------------------- ------ --------     -------- ------------------- ------------------------------   
                    a      Standard_LRS true
```



### Example 2: Make Premium V2 disks
```powershell
New-AzMigrateDiskMapping -DiskID b -DiskType PremiumV2_LRS -IsOSDisk 'false'
```

```output
DiskEncryptionSetId DiskId DiskType      IsOSDisk LogStorageAccountId LogStorageAccountSasSecretName  
------------------- ------ --------      -------- ------------------- ------------------------------   
                    b      PremiumV2_LRS false
```

Get disks object to provide input for New-AzMigrateServerReplication

## PARAMETERS

### -DiskEncryptionSetID
Specifies the disk encryption set to be used.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiskID
Specifies the disk ID of the disk attached to the discovered server to be migrated.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiskType
Specifies the type of disks to be used for the Azure VM.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsOSDisk
Specifies whether the disk contains the Operating System for the source server to be migrated.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtDiskInput

## NOTES

## RELATED LINKS

