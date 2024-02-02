using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Schluessel : MonoBehaviour
{

    public GameObject Tuer1;
    public GameObject Tuer2;
    private bool inTrigger;
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    private void Update()
    {
        if (inTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            Tuer1.GetComponent<Hg_DoorsScript>().setzeSchluessel(true,"Dr�cke e zum Verlassen");
            Tuer2.GetComponent<Hg_DoorsScript>().setzeSchluessel(true,"Dr�cke e zum Eintreten ");

            this.gameObject.SetActive(false);   
        }
    }
}
