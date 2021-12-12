using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class DerrickTrigger : MonoBehaviour
{
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject TheBox;
    public GameObject DerrickDialog;
    public AudioSource Audio3;
    public GameObject ActionDisplay;
    public GameObject DerrickText;
    public GameObject ExtraCross;
    public GameObject DarrickAnimation;

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
                this.GetComponent<BoxCollider>().enabled = false;
                TheBox.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                DerrickText.SetActive(false);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                StartCoroutine(ScenePlayer());
            }
        }
    }
    IEnumerator ScenePlayer() {
        DarrickAnimation.GetComponent<Animator>().Play("Talking");
        yield return new WaitForSeconds(0.2f);
        DerrickDialog.SetActive(true);
        //Audio3.Play();
        yield return new WaitForSeconds(1);
        DerrickDialog.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        DerrickDialog.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        this.GetComponent<BoxCollider>().enabled = true;
    }
    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        DerrickText.SetActive(false);
        ActionDisplay.SetActive(false);
    }
}

