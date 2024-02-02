using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Quiz_Antworten : MonoBehaviour
{
    
    public string buchstabe;
    private GameObject antwortten;

    private void Start()
    {
        antwortten = GameObject.FindGameObjectWithTag("Antworten");
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") == true && DialogueLua.GetVariable(buchstabe).asInt >= 3)
        {
            if (DialogueLua.GetVariable(buchstabe+buchstabe).asInt == 3)
            {
                if (buchstabe + buchstabe == "CC")
                {
                    antwortten.GetComponent<HG_Quiz>().PlayerToPos3();
                }
                else
                {
                    if (buchstabe + buchstabe == "AA")
                    {
                        Debug.Log("Gewonnen");
                    }
                    else
                    {
                        antwortten.GetComponent<HG_Quiz>().zurucksetzten();
                    }
                }
            }
            else
            {
                if (DialogueLua.GetVariable(buchstabe + buchstabe).asInt == 2)
                {

                        antwortten.GetComponent<HG_Quiz>().zurucksetzten();
                }
                else
                {
                    if (DialogueLua.GetVariable(buchstabe + buchstabe).asInt == 1)
                    {
                        if(buchstabe + buchstabe == "BB")
                        {
                            antwortten.GetComponent<HG_Quiz>().PlayerToPos2();
                        }
                        else
                        {
                            antwortten.GetComponent<HG_Quiz>().zurucksetzten();
                        }
                             

                    }
                }

               
            }
           
          
        }
    }

   

}
