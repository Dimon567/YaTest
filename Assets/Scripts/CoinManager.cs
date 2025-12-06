using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _countCoinsOnLevel = 0;
    [SerializeField] private TextMeshProUGUI _textCoinCounter;

    private void Start()
    {
        
    }
    public void AddCoin()
    {
        _countCoinsOnLevel++;
        _textCoinCounter.text = _countCoinsOnLevel.ToString();
    }
}
