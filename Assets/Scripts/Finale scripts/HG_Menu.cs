using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Menu : MonoBehaviour
{
    private HG_ONSceneLaod _Loader;

    private void Awake()
    {
        if (GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>() != null)
        {
            _Loader = GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>();

        }
    }

    public void On_Start_Click()
    {
        _Loader.LadeScene("Health");
    }

    public void beendeSpiel()
    {
        Application.Quit();
    }
}
