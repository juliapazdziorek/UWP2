using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour , IInventory {
    private List<ItemSO> storedItems = new List<ItemSO>();

    public int Coins { get; private set; }
    public int Keys{ get; private set; }


    public void AddItemData(ItemSO itemData){
        storedItems.Add(itemData);
        Debug.Log($"Dodano do ekwipunku: {itemData.itemName}");
    }

    public void AddCoins(int amount){
        Coins += amount;
        Debug.Log($"Zebrano monety. Pula monet: {Coins}");
    }

    public void AddKeys(int amount){
        Keys += amount;
        Debug.Log($"Zebrano klucze. Pula kluczy: {Keys}");
    }
}
