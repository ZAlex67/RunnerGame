using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private int _numberOfCoins;

    public int NumberOfCoins => _numberOfCoins;

    private void Start()
    {
        _numberOfCoins = Progress.Instance.Coins;
        _text.text = _numberOfCoins.ToString();
    }

    public void AddOne()
    {
        _numberOfCoins += 1;
        _text.text = _numberOfCoins.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.Coins = _numberOfCoins;
    }

    public void SpendMoney(int value)
    {
        _numberOfCoins -= value;
        _text.text = _numberOfCoins.ToString();
    }
}
