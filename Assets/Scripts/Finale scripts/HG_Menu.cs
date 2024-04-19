using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Menu : MonoBehaviour    
{
    private HG_ONSceneLaod _Loader;

    [SerializeField] private GameObject reset;

    public GameObject Canvasbuttons;
    public GameObject background;
    public GameObject Quellen;
   public GameObject warteScreen;

    private void Awake()
    {
        if (GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>() != null)
        {
            _Loader = GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>();

        }
    }

    public void On_Start_Click()
    {
        reset.SetActive(true);              


        _Loader.LadeScene("Health");
    }

    public void beendeSpiel()
    {
        Application.Quit();
    }
    public void OnQuelle()
    {
        warteScreen.SetActive(false);
        Quellen.SetActive(true);
        background.SetActive(false);
        Canvasbuttons.SetActive(false);
    }
    public void zurueck()
    {
        warteScreen.SetActive(false);
        Quellen.SetActive(false);
        background.SetActive(true);
        Canvasbuttons.SetActive(true);
    }
    public void zweischenscreen()
    {
        warteScreen.SetActive(true);
        Quellen.SetActive(false);
        background.SetActive(false);
        Canvasbuttons.SetActive(false);
    }
}
