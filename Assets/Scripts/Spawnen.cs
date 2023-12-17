using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

//Simeon
public class Spawnen : MonoBehaviour
{
    public GameObject play, loadingzone, kamera; //kameraRef;
    //public Screen_Wechsel screen_Wechsel;

    public string letzterScreen;
    public CinemachineVirtualCamera kameraComponente;
    public Screen_Wechsel screen_Wechsel;
    //[SerializeField]
    public void OnEnable()
    {

        GameObject spieler = Instantiate(play);
        GameObject scenenWechselTrigger = Instantiate(loadingzone);
        loadingzone = GameObject.Find("ScreenTransition(Clone)");
        screen_Wechsel = loadingzone.GetComponent<Screen_Wechsel>();
        if (screen_Wechsel == null)
        {
            Debug.Log("reingeschissen");
        }

 screen_Wechsel.reffisFuellen(); 
        //screen_Wechsel = scenenWechselTrigger.GetComponent<screen_Wechsel>();
        //kamera = GameObject.Find("CM vcam1");
        GameObject screenKam = Instantiate(kamera);
        //kameraComponente = kamera.getComponent<CinemachineVirtualCamera>();

    }
}