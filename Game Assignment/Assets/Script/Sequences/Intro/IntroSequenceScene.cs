using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequenceScene : MonoBehaviour
{
    public GameObject textBox;
    public GameObject DateDisplay;
    public GameObject DividerImage;
    public GameObject PlaceDisplay;
    public AudioSource Audio1;
    public GameObject Allblack;
    public GameObject LoadText;
    //public GameObject MainCamera;


    void Start()
    {
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin()
            
    {
        yield return new WaitForSeconds(3);
        PlaceDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        DividerImage.SetActive(true);
        yield return new WaitForSeconds(1);
        DateDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        PlaceDisplay.SetActive(false);
        DateDisplay.SetActive(false);
        DividerImage.SetActive(false);
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "Warghhhhhhhhhhhhhhhhhhhhhhhhhhhhh!";
        Audio1.Play();
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        Allblack.SetActive(true);
        yield return new WaitForSeconds(5);
        LoadText.SetActive(true);
        SceneManager.LoadScene(3);
        //MainCamera.SetActive(false);

    }

}
