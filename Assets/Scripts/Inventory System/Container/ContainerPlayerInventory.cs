 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerPlayerInventory : Container
{
    public ContainerPlayerInventory(Inventory containerInventory, Inventory playerInventory) : base (containerInventory, playerInventory)
    {
        
    }

    public override GameObject getContainerPrefab()
    {
       return InventoryManager.INSTANCE.getContainerPrefab("Player Inventory");
    }
}
