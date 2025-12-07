using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int _nuberOfCoins = 0;
    [SerializeField] private TextMeshProUGUI _textCoinCounter;

    private void Start()
    {
        _nuberOfCoins = Progress.Instance.Coins;
        _textCoinCounter.text = _nuberOfCoins.ToString();
    }

    public void AddCoin()
    {
        _nuberOfCoins++;
        _textCoinCounter.text = _nuberOfCoins.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.Coins = _nuberOfCoins;
    }

    public bool SpendMoney(int coins)
    {
        if (_nuberOfCoins >= coins) {
            _nuberOfCoins -= coins;
            SaveToProgress();
            _textCoinCounter.text = _nuberOfCoins.ToString();
            return true;
        }
        return false;
        
    }
}
