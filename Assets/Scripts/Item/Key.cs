using UnityEngine;

public class Key : ItemBase {

    public override void PerformAction(GameObject player){
        if (player.TryGetComponent(out Inventory inventory)){
            inventory.AddCoins(itemData.amount);
        }
    }
}
