using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzleteil_Bewegung : MonoBehaviour
{
    public GameObject teilchen, container;
    public bool ambewegen, imFeld, touchi_touchi;
    public Vector3 mausPos;

    private float startPosX, startPosZ;
    void Update()
    {
        if (ambewegen)
        {
            mausPos = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector3(mausPos.x - startPosX,this.gameObject.transform.localPosition.y, mausPos.y - startPosZ);
        }
       
    }

    private void OnMouseDown ()
    {
        if (Input.GetMouseButtonDown (0))
        {
            mausPos = Input.mousePosition;
            startPosX = mausPos.x - this.transform.localPosition.x;
            startPosZ = mausPos.z - this.transform.localPosition.y;

            ambewegen = true;
        }
    }

    private void OnMouseUp ()
    {
        ambewegen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == container)
        {
            imFeld = true;
        }
        if (other.gameObject.CompareTag("Zeitungsteil"))
        {
            touchi_touchi = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == container)
        {
            imFeld = false;
        }
        if (other.gameObject.CompareTag("Zeitungsteil"))
        {
            touchi_touchi = false;
        }
        
    }

    public bool getImFeld()
    {
        return imFeld;
    }

    public bool getTouchi_Touchi()
    { return touchi_touchi; }

}
