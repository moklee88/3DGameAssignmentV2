using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject LoadText;
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;


	void Update()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			ExtraCross.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				StartCoroutine(NewGameStart());
			}
		}
	}
    IEnumerator NewGameStart()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2.95f);
        LoadText.SetActive(true);
        SceneManager.LoadScene(2);
		yield return new WaitForSeconds(2.95f);
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
}
