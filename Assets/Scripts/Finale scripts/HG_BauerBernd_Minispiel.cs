using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class HG_BauerBernd_Minispiel : MonoBehaviour
{



  


    public GameObject Tuer1;
    public GameObject Tuer2;



    [SerializeField]  private HG_ONSceneLaod  onSceneLoader;

    public GameObject zeitungssplitter;
    public GameObject zeitungganz;
    private void Awake()
    {

         onSceneLoader = GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>();
         GameObject bernd = GameObject.FindGameObjectWithTag("bernd");
         GameObject berndImHAus = GameObject.FindGameObjectWithTag("berndImHaus");

        if (onSceneLoader != null && onSceneLoader.gibErnte())
        {
            zeitungganz.SetActive(true);
            zeitungssplitter.SetActive(false);
            bernd.SetActive(false); 
            berndImHAus.SetActive(true);
        }
        else { bernd.SetActive(true); berndImHAus.SetActive(false); zeitungssplitter.SetActive(true); zeitungganz.SetActive(false); }



    }
   
    public void starteMinispiel()
    {
        Debug.Log("hss");
        onSceneLoader.LadeSzene("Bernd_Reaktion");
        schließeAuf();
    }

    public void schließeAuf()
    {
        Tuer1.GetComponent<Hg_DoorsScript>().setzeSchluessel(true, "Drücke e zum Verlassen");
        Tuer2.GetComponent<Hg_DoorsScript>().setzeSchluessel(true, "Drücke e zum Eintreten ");
    }




    /////
    ///
    // Code zum minispiel im haus 

    public void zweitesMInispeil()
    {
        onSceneLoader.LadeSzene("Zeitung_Puzzle");
        Debug.Log("fehelr");
    }











}
