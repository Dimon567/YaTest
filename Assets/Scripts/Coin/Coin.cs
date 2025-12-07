using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private GameObject _effectPrefab;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindFirstObjectByType<CoinManager>().AddCoin();
        Instantiate(_effectPrefab, transform.position, transform.rotation, transform.parent);
        Destroy(gameObject);
    }
}
