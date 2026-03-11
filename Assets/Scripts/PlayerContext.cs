using UnityEngine;

public class PlayerContext: MonoBehaviour {
    public Inventory inventory { get; private set; } = new Inventory();
    public Wallet wallet { get; private set; } = new Wallet();
    public PlayerHealth Health { get; private set; } = new PlayerHealth();
}
