using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Simeon
public class Teilspawner : MonoBehaviour
{
    public Sprite [] moeglicheTeile;

    public GameObject[] puzzleteil,container;
    public GameObject puzzlePrefab, feldPrefab;
    public int anzahlPuzzleTeile = 14;
    public Puzzleteil_Bewegung teilscript;
    public bool win;
    //Vector3 puzzleStelle
    // Start is called before the first frame update
    public void Awake()
    {

        puzzlePrefab = GameObject.Find("ZeitungsTeil");
        feldPrefab = GameObject.Find("Containerfeld");

        
        puzzleteil = new GameObject[anzahlPuzzleTeile];
        container = new GameObject[anzahlPuzzleTeile];

        for (int i = 0; i < anzahlPuzzleTeile; i++)
        {
            container[i] = Instantiate(feldPrefab, new Vector3(41.2f, 3.8f, 82.5f), Quaternion.identity);

            puzzleteil[i] = Instantiate(puzzlePrefab, new Vector3(71.7f, 3.34f, 97.4f), Quaternion.identity);
            teilscript = puzzleteil[i].GetComponent<Puzzleteil_Bewegung>();
            teilscript.container = container[i];
            teilscript.sailorMoonTransformation(moeglicheTeile[i]);
        }
    }

    public void OnMouseUp()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int anzahlRichtige = 0;
        for (int i = 0; i < anzahlPuzzleTeile; i++)
        {
            teilscript = puzzleteil[i].GetComponent<Puzzleteil_Bewegung>();
            if (teilscript.imFeld == true && teilscript.touchi_touchi == true)
            {
                anzahlRichtige++;
            }
            if (anzahlRichtige == anzahlPuzzleTeile)
            {
                win = true;
            }
        }
    }
}
