using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRandomizer : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] puzzelteile = GameObject.FindGameObjectsWithTag("aufheben");

        for(int i = 0; i < 14; i++)
        {
            puzzelteile[i].transform.position = new Vector3(Random.Range(-70f, 120f), -20, Random.Range(20f, 130f));
        }
    }


}
