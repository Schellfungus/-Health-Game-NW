using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Simeon
public class Screen_Wechsel : MonoBehaviour
{
    public string naesterScreen;
    public GameObject player, mainKamera;
    public WoPausirIch woPausirIch;
    //public Animator transition;

    
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
        player = GameObject.Find("IsAktiveManager");
        woPausirIch = player.GetComponent<WoPausirIch>();
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

    public void refferenzenFuellen(GameObject pPaler, string pScreen)
    {
        player = pPaler;
        naesterScreen = pScreen;
    }
}
