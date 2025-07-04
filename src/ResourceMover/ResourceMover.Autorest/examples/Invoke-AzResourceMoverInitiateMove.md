### Example 1: Validate the dependencies before Initiate Move for the resources.
```powershell
Invoke-AzResourceMoverInitiateMove -ResourceGroupName "RG-MoveCollection-demoRMS" -MoveCollectionName "PS-centralus-westcentralus-demoRMS"  -MoveResource $('psdemorm-vnet') -MoveResourceInputType "MoveResourceId" -ValidateOnly
```

```output
AdditionalInfo : 
Code           : 
Detail         : 
EndTime        : 2/10/2021 9:39:37 AM
Id             : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/RG-MoveCollection-demoRMS/providers/Microsoft.Migrate/moveCollections/PS-centralus-westcentralus-demoRMS/operations/095f3d5
                 1-ebd1-4c5b-9a65-d78ebe3ac345
Message        : 
Name           : 095f3d51-ebd1-4c5b-9a65-d78ebe3ac345
Property       : Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Any
StartTime      : 2/10/2021 9:39:37 AM
Status         : Succeeded

```

Validate the dependencies before Initiate Move for the resources. The same command can be used for both 'RegionToRegion' and 'RegionToZone' type move collections.


### Example 2: Initiate Move for the set of resources in the Move collection using "MoveResource Name" as input. (RegionToRegion)
```powershell
Invoke-AzResourceMoverInitiateMove -ResourceGroupName "RG-MoveCollection-demoRMS" -MoveCollectionName "PS-centralus-westcentralus-demoRMS"  -MoveResource $('psdemorm-vnet') -MoveResourceInputType "MoveResourceId" 
```

```output
AdditionalInfo : 
Code           : 
Detail         : 
EndTime        : 2/10/2021 11:56:33 AM
Id             : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/RG-MoveCollection-demoRMS/providers/Microsoft.Migrate/moveCollections/PS-centralus-westcentralus-demoRMS/operations/290472e3-c8de-4c55-aba1-3a34a7a4ab38
Message        : 
Name           : 290472e3-c8de-4c55-aba1-3a34a7a4ab38
Property       : Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Any
StartTime      : 2/10/2021 11:55:21 AM
Status         : Succeeded

```

Initiate Move for the set of resources in 'RegionToRegion' type Move collection using "MoveResource Name" as input.

### Example 3: Initiate Move for the set of resources in the Move collection using "MoveResource Name" as input. (RegionToZone)
```powershell
Invoke-AzResourceMoverInitiateMove -ResourceGroupName "RG-MoveCollection-demoRMS" -MoveCollectionName "PS-centralus-westcentralus-demoRMS" -MoveResource $('PSDemoVM-RegionToZone') -MoveResourceInputType "MoveResourceId" 
```

```output
AdditionalInfo :
Code           :
Detail         :
EndTime        : 9/5/2023 11:53:43 AM
Id             : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/RG-MoveCollection-demoRMS/providers/Microsoft.Migrate/moveCollections/PS-demo-RegionToZone/operations/26077f45-dd8a-4c55-aba1-3a34a7a4ab38
Message        :
Name           : 26077f45-dd8a-4c55-aba1-3a34a7a4ab38
Property       : Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Any
StartTime      : 9/5/2023 11:50:21 AM
Status         : Succeeded

```

Initiate Move for the set of resources in 'RegionToZone' type Move collection using "MoveResource Name" as input.

### Example 4: Initiate Move for the set of resources in the Move Collection using "SourceARMID" as input. (RegionToRegion)
```powershell
Invoke-AzResourceMoverInitiateMove -ResourceGroupName "RG-MoveCollection-demoRMS" -MoveCollectionName "PS-centralus-westcentralus-demoRMS"  -MoveResource $('/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/PSDemoRM/providers/Microsoft.Network/networkSecurityGroups/PSDemoVM-nsg') -MoveResourceInputType "MoveResourceSourceId"
```

```output
AdditionalInfo : 
Code           : 
Detail         : 
EndTime        : 2/10/2021 12:01:35 PM
Id             : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/RG-MoveCollection-demoRMS/providers/Microsoft.Migrate/moveCollections/PS-centralus-westcentralu
                 s-demoRMS/operations/955fd43c-10b6-481e-888b-d26d6ec42aea
Message        : 
Name           : 955fd43c-10b6-481e-888b-d26d6ec42aea
Property       : Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Any
StartTime      : 2/10/2021 12:00:21 PM
Status         : Succeeded

```

Initiate Move for the set of resources in 'RegionToRegion' type Move collection using "SourceARMID" as input.

### Example 5: Initiate Move for the set of resources in the Move Collection using "SourceARMID" as input. (RegionToZone)
```powershell
Invoke-AzResourceMoverInitiateMove -ResourceGroupName "RG-MoveCollection-demoRMS" -MoveCollectionName "PS-centralus-westcentralus-demoRMS" -MoveResource $('/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/PS-demo-RegionToZone-RG/providers/Microsoft.Compute/virtualMachines/demo-RegionToZone-VM') -MoveResourceInputType "MoveResourceSourceId"
```

```output
AdditionalInfo :
Code           :
Detail         :
EndTime        : 9/5/2023 11:58:43 AM
Id             : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/RG-MoveCollection-demoRMS/providers/Microsoft.Migrate/moveCollections/PS-demo-RegionToZone/operations/6078f452-10c6-441e-888b-d46d7ef42fed
Message        :
Name           : 6078f452-10c6-441e-888b-d46d7ef42fed
Property       : Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Any
StartTime      : 9/5/2023 11:56:03 AM
Status         : Succeeded

```

Initiate Move for the set of resources in 'RegionToZone' type Move collection using "SourceARMID" as input.
