using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject about;
    public GameObject problem;
    public SceneManager problem10;

    public void playGame()
    {
        menu.SetActive(false);
        problem.SetActive(true);
    }

    public void aboutGame()
    {
        menu.SetActive(false);
        about.SetActive(true);
    }

    public void back()
    {
        menu.SetActive(true);
        about.SetActive(false);
        problem.SetActive(false);
    }

    public void Scene(int i)
    {
        SceneManager.LoadScene("Problem"+i);
    }

    public void exitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
