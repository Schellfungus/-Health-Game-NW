using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Simeon
public class Puzzleteil_Bewegung : MonoBehaviour
{
    public GameObject teilchen, container;
    public bool ambewegen, imFeld, touchi_touchi;
    public Vector3 mausPos;

    private float startPosX, startPosZ;


    void Awake()
    {
        transform.localScale = new Vector3(20f, 15f, 3f);
        transform.Rotate(new Vector3(90f, 0f, 0f));
    }

    public void sailorMoonTransformation (Sprite look)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = look;
    }

    void Update()
    {
        if (ambewegen)
        {
            Plane bodenPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (bodenPlane.Raycast(ray, out float rayLaenge))
            {
                Vector3 mausPosition = ray.GetPoint(rayLaenge);
                transform.position = new Vector3(mausPosition.x - startPosX, transform.position.y, mausPosition.z - startPosZ);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Plane bodenPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (bodenPlane.Raycast(ray, out float rayLaenge))
            {
                Vector3 mausPosition = ray.GetPoint(rayLaenge);
                startPosX = mausPosition.x - transform.position.x;
                startPosZ = mausPosition.z - transform.position.z;

                ambewegen = true;
            }
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
