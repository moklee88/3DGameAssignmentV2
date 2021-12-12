using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cancel : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject LoadText;
    public AudioSource ButtonClick;

    public void CancelButton()
    {
        StartCoroutine(NewGameStart());
    }
    IEnumerator NewGameStart()
    {
        FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(2.95f);
        LoadText.SetActive(true);
        SceneManager.LoadScene(0);

    }
}
