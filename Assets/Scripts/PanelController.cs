using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PanelController : MonoBehaviour
{
    public TextMeshProUGUI maxScoreText;
    public void MenuButtonClicked()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void ReplayButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.Instance.isGameOver = false;
    }
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("GameScene");
        GameManager.Instance.isGameOver = false;
    }

    private void Start()
    {
        maxScoreText.text = "record " +  GameManager.Instance.GetMaxScore().ToString();  
    }
}
