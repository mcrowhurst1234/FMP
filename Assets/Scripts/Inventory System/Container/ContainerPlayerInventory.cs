 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerPlayerInventory : Container
{
    public ContainerPlayerInventory(Inventory containerInventory, Inventory playerInventory) : base(containerInventory, playerInventory)
    {
        for (int i = 0; i < 5; i++)
        {
            addSlotToContainer(playerInventory, i, 30 + (100 * i), -30, 100);
        }

        for (int i = 0; i < 5; i++)
        {
            addSlotToContainer(playerInventory, 6 + i, 30 + (100 * i), -180, 100);
        }

        for (int i = 0; i < 5; i++)
        {
            addSlotToContainer(playerInventory, 12 + i, 30 + (100 * i), -340, 100);
        }

        for (int i = 0; i < 5; i++)
        {
            addSlotToContainer(playerInventory, 12 + i, 30 + (100 * i), -500, 100);
        }

        for (int i = 0; i < 5; i++)
        {
            addSlotToContainer(playerInventory, 12 + i, 28 + (100 * i), -680, 100);
        }
    }

    public override GameObject getContainerPrefab()
    {
        return InventoryManager.INSTANCE.getContainerPrefab("Player Inventory");
    }
}
