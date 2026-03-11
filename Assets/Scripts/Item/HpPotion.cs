using UnityEngine;

public class HpPot : ItemBase {

    protected override void PerformAction(PlayerContext player){
        player.healable?.HealDamage(itemData.amount);
    }
}
