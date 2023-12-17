using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Simeon
public class Screen_Wechsel : MonoBehaviour
{
    public string naesterScreen;
    public GameObject player, mainKamera, manager;
    public WoPausirIch woPausirIch;
    //public Animator transition;

    public void Awake ()
    {
        reffisFuellen();
    }
    
    public void setNaecsterScreen(string pNaesterScreen)
    {
        naesterScreen = pNaesterScreen;
    }
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LadeSzeneMitPause());
    }

    IEnumerator LadeSzeneMitPause()
    {
        //Refferenzen bekommen
        reffisFuellen();
        //mainKamera = GameObject.Find("CM vcam1");
        //transition = mainKamera.GetComponent<Animator>();
        //if (mainKamera == null)
        //{
            //Debug.Log("reingeschisen");
        //}
        //Ausführen
        woPausirIch.playerIsAktive = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(naesterScreen);
        woPausirIch.playerIsAktive = true;
    }

    public void reffisFuellen ()
    {
        manager = GameObject.Find("IsAktiveManager");
        woPausirIch = manager.GetComponent<WoPausirIch>();
    }
    
}
