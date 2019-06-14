using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScritp : MonoBehaviour
{
    public void Quiting()
    {
        Application.Quit();
    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMeny()
    {
        SceneManager.LoadScene("Meny");
    }
}
