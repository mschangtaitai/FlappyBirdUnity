using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
