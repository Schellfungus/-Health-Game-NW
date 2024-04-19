using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class HG_NPC_Script : MonoBehaviour
{

   

    private Animator npcAnimator;


    // Start is called before the first frame update
    void Start()
    {

        npcAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && transform.rotation.y == 0)
        {

            npcAnimator.SetTrigger("NPCFlipper");

        }
     

    }

}
