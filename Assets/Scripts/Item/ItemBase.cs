using UnityEngine;

public abstract class ItemBase : MonoBehaviour,ICollectable{
    public ItemSO itemData;

    protected abstract void PerformAction(PlayerContext player);

    public void Collect(PlayerContext player)
    {
        PerformAction(player);
        if (player.inventory != null)
        {
            player.inventory.AddItemData(itemData);
        }
        Destroy(gameObject);
    }
}
