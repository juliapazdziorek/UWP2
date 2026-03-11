using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> storedItems = new List<string>();

    public int Coins { get; private set; }

    public void AddItem(string itemName)
    {
        storedItems.Add(itemName);
        Debug.Log($"Dodano do ekwipunku: {itemName}");
    }

    public void AddCoins(int amount)
    {
        Coins += amount;
        Debug.Log($"Zebrano monety. Pula monet: {Coins}")
    }
    
}
