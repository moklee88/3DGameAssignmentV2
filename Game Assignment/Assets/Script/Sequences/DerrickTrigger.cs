using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class DerrickTrigger : MonoBehaviour
{
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject TextBox;
    public AudioSource Audio3;
    public GameObject ActionDisplay;
    public GameObject DerrickText;
    public GameObject ExtraCross;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            DerrickText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                ActionDisplay.SetActive(false);
                DerrickText.SetActive(false);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                StartCoroutine(ScenePlayer());
            }
        }
    }
    IEnumerator ScenePlayer() {
        TextBox.GetComponent<Text>().text = "Look Like A Weapon On The Table";
        Audio3.Play();
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}

