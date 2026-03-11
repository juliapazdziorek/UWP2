using UnityEngine;

public class PlayerContext: MonoBehaviour {
    public Inventory inventory { get; private set; } = new Inventory();
    public PlayerHealth Health { get; private set; } = new PlayerHealth();

    private void Awake()
    {
        Inventory = GetComponent<Inventory>();
        Health = GetComponent<PlayerHealth>();
    }
    
}
