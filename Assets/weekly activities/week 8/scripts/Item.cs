using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
  [SerializeField]  private string itemName;
    [SerializeField] private int itemID;
    [SerializeField] private string itemUse;
    [SerializeField] private bool isQuestItem;
    [SerializeField] private int costInGold;


    public string GetItemName()
    {
        return itemName;
    }
    public int GetItemID()
    {
        return itemID;
    }
    public bool GetIsQuestItem()
    {
        return isQuestItem;
    }
    public void SetItemName(string newName)
    {
        itemName = newName;
    }
}
