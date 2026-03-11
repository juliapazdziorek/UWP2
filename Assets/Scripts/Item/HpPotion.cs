using UnityEngine;

public class HpPot : ItemBase {

    public override void PerformAction(GameObject player){
        if (player.TryGetComponent(out PlayerHealth health)){
            health.HealDamage(itemData.amount);
        }
    }
}
