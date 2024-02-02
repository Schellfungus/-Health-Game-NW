using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Quiz : MonoBehaviour
{

    private GameObject CameraPos1;
    private GameObject CameraPos2;
    private GameObject CameraPos3;
    private GameObject CameraPosMain;

    private Transform playerSpawnPoint1;
    private Transform playerSpawnPoint2;
    private Transform playerSpawnPoint3;
    private Transform playerSpawnPointMain;

    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        CameraPos1 = GameObject.FindGameObjectWithTag("Winkel1");
        CameraPos2 = GameObject.FindGameObjectWithTag("Winkel2");
        CameraPos3 = GameObject.FindGameObjectWithTag("Winkel3");
        CameraPosMain = GameObject.FindGameObjectWithTag("CameraMain");

        playerSpawnPoint1 = GameObject.FindGameObjectWithTag("PlayerPos1").transform;
        playerSpawnPoint2 = GameObject.FindGameObjectWithTag("PlayerPos2").transform;
        playerSpawnPoint3 = GameObject.FindGameObjectWithTag("PlayerPos3").transform;
        playerSpawnPointMain = GameObject.FindGameObjectWithTag("PlayerPosMAin").transform;
    }
    public void PlayerToPos1()
    {
        player.transform.position = playerSpawnPoint1.position;
        Camera.main.transform.parent = CameraPos1.transform; 
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;

    }

    public void PlayerToPos2()
    {
        player.transform.position = playerSpawnPoint2.position;
        Camera.main.transform.parent = CameraPos2.transform;
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
        Debug.Log("HEyyyy");
    }

    public void PlayerToPos3()
    {
        player.transform.position = playerSpawnPoint3.position;
        Camera.main.transform.parent = CameraPos3.transform;
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
    }

    public void zurucksetzten()
    {
        player.transform.position = playerSpawnPointMain.position;
        Camera.main.transform.parent = CameraPosMain.transform;
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
    }
}
