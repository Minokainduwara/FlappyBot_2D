using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public GameObject creditsPanel;
    private void Start()
    {
        creditsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("scene1");
    }

    public void Back()
    {
        creditsPanel.SetActive(false);
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
        Debug.Log("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
