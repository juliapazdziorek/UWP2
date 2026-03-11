using UnityEngine;

public class Key : ItemBase {

    protected override void PerformAction(PlayerContext player){
        player.inventory?.AddKeys(itemData.amount);
    }
}
