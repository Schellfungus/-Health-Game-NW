using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerZaehler : MonoBehaviour
{
    public bool imFeld;
    private void OnTriggerEnter(Collider other)
    {
        imFeld = true;
    }
    private void OnTriggerExit(Collider other)
    {
        imFeld = false;
    }
    public void sailormoonUndSo(Sprite look)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = look;
    }
}
