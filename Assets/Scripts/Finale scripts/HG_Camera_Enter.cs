using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_Camera_Enter : MonoBehaviour
{
    public Transform targetEmptyObject; // Das leere GameObject, auf das die Kamera gesetzt werden soll

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            SwitchCamera(); 
        }
    }

    private void SwitchCamera()
    {
        Camera.main.transform.parent = targetEmptyObject; // Die Kamera auf das leere GameObject setzen
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
        
    }
}
