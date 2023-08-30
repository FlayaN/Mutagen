# Binary Exporting
## Typical Export
A basic mod write call is pretty straightforward:
```
mod.WriteToBinary(desiredFilePath);
```

But the recommended call for exporting a mod has some extra parameters:
```
mod.WriteToBinary(
    desiredFilePath,
    new BinaryWriteParameters()
    {
        MastersListOrdering = new MastersListOrderingByLoadOrder(loadOrder)
    });
```

This extra information helps keep the masters in proper order, as the load order information is provided for the write call to use.  More information can be found about the details in the following sections.

### Master Content
Mutagen automatically handles the logic to determine which masters are required.  It will iterate all records for:
- Overridden 

### Master Ordering
Typically, the order that masters are written 


## Master Sync Options