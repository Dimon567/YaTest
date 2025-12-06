using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

        if(playerModifier != null)
        {
            playerModifier.HitBarrier();
            Destroy(gameObject);
        }
    }
}
