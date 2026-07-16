using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
   [SerializeField] private List<Item> itemList = new List<Item> ();

    private void Start()
    {
        OpenInventory();
    }

    //output to the console every item's use
    private void OpenInventory()
    {
        foreach(Item currentItem in itemList)
        {
            Debug.Log(currentItem.GetItemName());
            Debug.Log(currentItem.GetItemID());
            Debug.Log(currentItem.GetIsQuestItem());
        }
    }
}
