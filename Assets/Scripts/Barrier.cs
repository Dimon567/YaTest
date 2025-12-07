using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private GameObject _bricksEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

        if(playerModifier != null)
        {
            playerModifier.HitBarrier();
            Instantiate(_bricksEffectPrefab, transform.position, transform.rotation, transform.parent);
            Destroy(gameObject);
        }
    }
}
