using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_AnnasFreund : MonoBehaviour
{

    private GameObject bush;

    private void Awake()
    {
        bush = GameObject.FindGameObjectWithTag("Bush");
    }
    public void wegMitDemBusch()
    {
        bush.SetActive(false);  
    }
}
