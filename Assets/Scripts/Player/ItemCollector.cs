using UnityEngine;

public class ItemCollector: MonoBehaviour {
    private PlayerContext playerContext;

    private void Awake(){
        playerContext = GetComponent<PlayerContext>();
    }
    
    
    private void OnTriggerEnter(Collider other){
        if (other.TryGetComponent(out ICollectable collectable)){
            collectable.Collect(playerContext);
        }
    }
}
