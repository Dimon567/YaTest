using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;
    [SerializeField] int _salary;
    [SerializeField] int _value;
    [SerializeField] Button _buttonBuyWidth;
    [SerializeField] Button _buttonBuyHeight;

    private PlayerModifier _playerModifier;

    private void OnValidate()
    {
        _buttonBuyWidth.transform.GetComponentInChildren<TextMeshProUGUI>().text = _salary.ToString();
        _buttonBuyHeight.transform.GetComponentInChildren<TextMeshProUGUI>().text = _salary.ToString();
    }

    private void Start()
    {
        _playerModifier = FindAnyObjectByType<PlayerModifier>();
        _buttonBuyWidth.onClick.AddListener(BuyWidth);
        _buttonBuyHeight.onClick.AddListener(BuyHeight);
    }

    public void BuyWidth()
    {
        if (_coinManager.SpendMoney(_salary))
        {
            Progress.Instance.Width += _value;
            _playerModifier.AddWidth(_value);
        }
    }

    public void BuyHeight() 
    {
        if (_coinManager.SpendMoney(_salary))
        {
            Progress.Instance.Height += _value;
            _playerModifier.AddHeight(_value);
        }
    }
}
