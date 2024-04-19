using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class HG_activeSetzter : MonoBehaviour
{
    private void Awake()
    {
        HG_ONSceneLaod onSceneLoader;
        onSceneLoader = GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>();

            onSceneLoader.LadeScene("Zeitung_Puzzle");

    }
    private void Update()
    {
        
    }
}
