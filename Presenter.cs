using UnityEngine;
using UnityEngine.UI;

public class CoinsPresenter : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            OnPickupCoin();
    }

    public void OnPickupCoin()
    {
        _amount++;
        _render.text = $"Coins: {_amount}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", _amount);
    }
}
