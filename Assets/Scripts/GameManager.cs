using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button _playButton;
    [SerializeField] GameObject _UpgradeMenu;
    public void Play()
    {
        _playButton.gameObject.SetActive(false);
        _UpgradeMenu.gameObject.SetActive(false);
        FindAnyObjectByType<PlayerBehaviour>().Play();
    }
}
