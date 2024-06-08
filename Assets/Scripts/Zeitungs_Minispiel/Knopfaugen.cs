using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knopfaugen : MonoBehaviour
{
    public bool neustart = false;
    void Awake()
    {
        //this.onClick.AddListener(clickClack);
    }
    
    // Start is called before the first frame update
    public void OnOpenButtonClick()
    {
        neustart = true;
        Debug.Log("Jahuhuhuj");
    }

    public void verstecken(bool pJN)
    {
        gameObject.SetActive(pJN);
    }
}
