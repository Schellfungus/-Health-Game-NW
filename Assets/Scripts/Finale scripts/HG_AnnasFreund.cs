using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_AnnasFreund : MonoBehaviour
{

    private GameObject bush;
    private static bool bushher = true;
    private void Awake()
    {
        bush = GameObject.FindGameObjectWithTag("Bush");
        bush.SetActive(bushher);
    }
    public void wegMitDemBusch()
    {
        bushher = false;
        Debug.Log("" + bushher);
        bush.transform.position = new Vector3(1000, 10001, 1000);

    }
}
