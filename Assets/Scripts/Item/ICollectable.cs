using UnityEngine;

public interface ICollectable{
    void Collect(PlayerContext player);
}

public interface IHealable{
    void HealDamage(int amount);
}

public interface IInventory{
    void AddCoins(int amount);
    void AddKeys(int amount);
    void AddItemData(ItemSO itemData);
}