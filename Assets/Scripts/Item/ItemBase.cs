using UnityEngine;

public enum Type{
    Coin,
    Key,
    HealthPotion
}

public abstract class ItemBase : MonoBehaviour,IInteractible{
    public ItemSO itemData;
    public abstract void PerformAction(GameObject player);

    public void Collect(GameObject player){
        PerformAction(player);
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter(Collider collision) {
        if (collision.CompareTag("Player")) {
            Interact(collision.gameObject);
        }
    }
}
