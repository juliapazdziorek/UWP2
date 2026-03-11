using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<ItemBase> storedItems = new List<ItemBase>();

    public int Coins { get; private set; }
    public int Keys{ get; private set; }

    public void AddItem(ItemBase itemName)
    {
        storedItems.Add(itemName);
        Debug.Log($"Dodano do ekwipunku: {itemName.itemData.type}");
    }

    public void AddCoins(int amount)
    {
        Coins += amount;
        Debug.Log($"Zebrano monety. Pula monet: {Coins}");
    }

    public void AddKeys(int amount){
        Keys += amount;
        Debug.Log($"Zebrano klucze. Pula kluczy: {Keys}");
    }
}
