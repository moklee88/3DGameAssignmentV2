using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer() {
        yield return new WaitForSeconds (1.5f);
        FadeScreenIn.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }

}
