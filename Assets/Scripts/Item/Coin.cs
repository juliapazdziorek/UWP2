using UnityEngine;

public class Coin : ItemBase{
    protected override void PerformAction(PlayerContext player){
        player.inventory?.AddCoins(itemData.amount);
    }
}
