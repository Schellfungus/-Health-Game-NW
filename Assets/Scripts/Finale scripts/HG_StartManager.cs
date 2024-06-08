using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_StartManager : MonoBehaviour
{
   

    public GameObject FirstWinkel;

    public GameObject FirstSpawnPoint;
    private void Awake()
    {
     

         
           GameObject.FindGameObjectWithTag("HG_OnSceneLoad").GetComponent<HG_ONSceneLaod>().ersterloade(FirstWinkel, FirstSpawnPoint);





    }
}
