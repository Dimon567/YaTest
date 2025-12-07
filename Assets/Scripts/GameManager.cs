using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button _playButton;
    [SerializeField] GameObject _UpgradeMenu;
    [SerializeField] TextMeshProUGUI _levelTitleText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] CoinManager _coinManager;

    private void Start()
    {
        _levelTitleText.text = SceneManager.GetActiveScene().name;
        _finishWindow.SetActive(false);
    }

    public void Play()
    {
        _playButton.gameObject.SetActive(false);
        _UpgradeMenu.gameObject.SetActive(false);
        FindAnyObjectByType<PlayerBehaviour>().Play();
    }

    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }

    public void NextLevel()
    {
        _coinManager.SaveToProgress();

        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(next);
        } 
    }
}
