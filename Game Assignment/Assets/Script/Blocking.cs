using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocking : MonoBehaviour
{
    public float TheDistance;
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
            DerrickText.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        DerrickText.SetActive(false);
    }
}
