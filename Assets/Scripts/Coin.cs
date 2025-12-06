using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    void Start()
    {
        
    }

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
        Destroy(gameObject);
    }
}
