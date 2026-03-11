using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealable
{
    private int _health = 100;

    public void HealDamage(int healAmount)
    {
        _health += healAmount;
        Debug.Log($"Zebrano Hp potke. Dodano zdrowie : {healAmount}");
    }
}
