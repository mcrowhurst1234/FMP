using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    private GameObject spawnedContainerPrefab;
    private Inventory containerInventory;
    private Inventory playerInventory; 

    public Container(Inventory containerInventory, Inventory playerInventory)
    {
        this.containerInventory = containerInventory;
        this.playerInventory = playerInventory;
    } 

    public void openContainer()
    {

    }

    public void closeContainer()
    {

    }

    public virtual GameObject getContainerPrefab()
    {
        return null; 
    }

    public GameObject getSpawnedContainer()
    {
        return spawnedContainerPrefab; 
    }

    public Inventory getContainerInventory()
    {
        return containerInventory; 
    }

    public Inventory getPlayerInventory()
    {
        return playerInventory; 
    }
}
