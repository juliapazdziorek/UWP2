using UnityEngine;

public class PlayerContext: MonoBehaviour {
    public IInventory inventory { get; private set; }
    public IHealable healable { get; private set; }
    public PlayerMovement movement { get; private set; }

    private void Awake(){
        inventory = GetComponent<IInventory>();
        healable = GetComponent<IHealable>();
        movement = GetComponent<PlayerMovement>();
    }
    
}
