
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HG_ONSceneLaod : MonoBehaviour
{
  

    private GameObject _Player;

    private int spawnErkenner = -1;

    public static HG_ONSceneLaod dieses;


    [SerializeField] private GameObject _loaderCanvas;

    [SerializeField]  public Image _progressBar;

     private float target_Delay = 0.2f;
    private void Awake()
    {
       

        if (dieses == null)
        {
            dieses = this;
            DontDestroyOnLoad(gameObject);
            _Player = GameObject.FindGameObjectWithTag("Player");
        }
        else Destroy(gameObject);

        _loaderCanvas.SetActive(false);
    }



    public async void LadeScene(string sceneName)
    {
        
        target_Delay = 0;
        _progressBar.fillAmount = 0;


       var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

   

        while (_progressBar.fillAmount < 0.9f && scene.progress < 0.9)
         {
            await Task.Delay(500);


            _progressBar.fillAmount = _progressBar.fillAmount + 0.2f;
            Debug.Log("Fehler");
         }

        scene.allowSceneActivation = true;



        await Task.Delay(1000);

        _loaderCanvas.SetActive(false);
        
       

    }

 
    
        
    




    public void LadeSzene(string SzenenName)
    {



        if(SzenenName == "aA")
        {
            spawnErkenner = 3;
            LadeScene("newone"); 
        }
        if (SzenenName == "bB")
        {
            spawnErkenner = 4;
            LadeScene("Bürgermeister");
        }
        if (SzenenName == "rathaus")
        {
            spawnErkenner = 1;
            
            LadeScene("BauerBernd");
        }
        if(SzenenName == "main")
        {

            LadeScene("Health");
        }
        if(SzenenName == "inRathaus")
        {
            spawnErkenner = 2;
            LadeScene("Im_Rathaus");
        }
    }


    


    public void BewegeSpielerUndCamera(Transform playerSpawn,Transform CameraSpawn)
    {
        _Player = GameObject.FindGameObjectWithTag("Player");

        _Player.transform.position = playerSpawn.position;
        Camera.main.transform.parent = CameraSpawn;
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
    }



    public int getSpawnErkenner()
    {
        return spawnErkenner;   
    }

    // 0 = main
    // 1 = ausenBurgermeister
    // 2 = ImRathaus
    // 3 = AA
    // 4 = BB
    // 5 = Puzzle Minigame

}
