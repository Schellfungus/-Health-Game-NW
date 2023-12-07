using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dieter_Move : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hilfe");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.01f, 0, 0);
    }

    Vector3 getPosition()
    {
        return transform.position;
    }
}
