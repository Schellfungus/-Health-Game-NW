using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Simeon
public class WoPausirIch : MonoBehaviour
{
    public GameObject player;
    public bool isPause;
    [SerializeField] public  bool playerIsAktive;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject player = GameObject.Find("PPaler");
        //player.SendMessage("pause");
        DontDestroyOnLoad(gameObject);
        isPause = true;
        playerIsAktive=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
