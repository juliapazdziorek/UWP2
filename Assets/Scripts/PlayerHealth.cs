using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _health = 100;

    public void Heal(int healAmount)
    {
        _health += healAmount;
        Debug.Log($"Leczenie o {healAmount}. Aktualne HP: {_health}");
    }
}
