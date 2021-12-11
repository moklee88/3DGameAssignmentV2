using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomDoubleDoorRoom1 : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor1;
	public GameObject TheDoor2;
	public AudioSource CreakSound;
	public GameObject ExtraCross;

	void Update()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 2)
		{
			ExtraCross.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 2)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				TheDoor1.GetComponent<Animation>().Play("BottomDoorRight");
				TheDoor2.GetComponent<Animation>().Play("BottomDoorLeft");
				CreakSound.Play();
			}
		}
	}

	void OnMouseExit()
	{
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
}
