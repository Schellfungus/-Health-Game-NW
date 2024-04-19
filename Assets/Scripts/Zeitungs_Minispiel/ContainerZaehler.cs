using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ContainerZaehler : MonoBehaviour
{
    public bool imFeld;
    public string achtenAuf;
    public static int Zaeheler = 0;
    private bool bugFixes = true;

    public static DragAndDropMinigame DandDM;

    private static int methodenzaehelr;

    private void Awake()
    {
        DandDM = GameObject.FindGameObjectWithTag("AufhebManager").GetComponent<DragAndDropMinigame>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == achtenAuf && !imFeld && DandDM.selectedObject == null)
        {
            imFeld = true;
            Zaeheler++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == achtenAuf && imFeld)
        {
            imFeld = false;
            Zaeheler--;
        }
    }
    private void Update()
    {
        if(Zaeheler == 14 && bugFixes)
        {
            gewinner();
            bugFixes = false;
        }
    }
    public static void gewinner()
    {

        methodenzaehelr++;

        if(methodenzaehelr == 14)
        {
            Debug.Log("winnerwinner chiken dinner0");
           
            DandDM.gewonnen();

        }
    }




    public void sailormoonUndSo(Sprite look)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = look;
    }
}
