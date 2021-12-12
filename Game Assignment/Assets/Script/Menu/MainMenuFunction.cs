using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject LoadText;
    public AudioSource ButtonClick;

   public void NewGameButton()
    {
        StartCoroutine(NewGameStart()); 
    }

    public void CreditButton()
    {
        StartCoroutine(Credit());
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    IEnumerator NewGameStart()
    { 
       FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(2.95f);
        LoadText.SetActive(true);
        SceneManager.LoadScene(2);
    }
    IEnumerator Credit()
    {
        FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(2.95f);
        LoadText.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
