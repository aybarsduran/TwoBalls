using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
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
}
