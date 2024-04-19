using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Simeon
public class Teilspawner : MonoBehaviour
{
    public Sprite[] moeglicheTeile;

    public GameObject[] puzzleteil, container;
    public GameObject puzzlePrefab, feldPrefab, Kamera;

    public int anzahlPuzzleTeile = 14;
    public Vector3[] teilpositionen;

    public Puzzleteil_Bewegung teilscript;
    public ContainerZaehler conscript;

    public ContainerZaehler immerFeld;
    //Vector3 puzzleStelle
    // Start is called before the first frame update
    public void Awake()
    {
        Kamera = GameObject.Find("Main Camera");
        puzzlePrefab = GameObject.Find("ZeitungsTeil");
        feldPrefab = GameObject.Find("Containerfeld");


        puzzleteil = new GameObject[anzahlPuzzleTeile];
        container = new GameObject[anzahlPuzzleTeile];
        for (int i = 0; i < anzahlPuzzleTeile; i++)
        {

            puzzleteil[i] = Instantiate(puzzlePrefab, new Vector3(55f * i * 3 + 10, 3.34f, 15 * i + 25), Quaternion.identity);
            container[i] = Instantiate(feldPrefab, teilpositionen[i], Quaternion.identity);

            teilscript = puzzleteil[i].GetComponent<Puzzleteil_Bewegung>();
            conscript = container[i].GetComponent<ContainerZaehler>();
            
            //teilscript.container = container[i];
            teilscript.container = container[i];
            teilscript.sailorMoonTransformation(moeglicheTeile[i]);
            conscript.sailormoonUndSo(moeglicheTeile[i]);
        }
    }




    // Update is called once per frame
    void Update()
    {
        int anzahlRichtige = 0;
        float kameraSize = Camera.main.orthographicSize;
        for (int i = 0; i < anzahlPuzzleTeile; i++)
        {
            //Bleib im Screen du Wichser
            if (puzzleteil[i].transform.position.z < kameraSize)
            {
                puzzleteil[i].transform.position = new Vector3( puzzleteil[i].transform.position.x,transform.position.y, kameraSize+20);
            }
            if (puzzleteil[i].transform.position.z > 160)
            {
                puzzleteil[i].transform.position = new Vector3(puzzleteil[i].transform.position.x, puzzleteil[i].transform.position.y,120);
            }
            if (puzzleteil[i].transform.position.x < kameraSize)
            {
                puzzleteil[i].transform.position = new Vector3(kameraSize, puzzleteil[i].transform.position.y, puzzleteil[i].transform.position.z);
            }
            if  (puzzleteil[i].transform.position.x > 180)
            {
                puzzleteil[i].transform.position = new Vector3(160, puzzleteil[i].transform.position.y, puzzleteil[i].transform.position.z);
            }
            //Kontrolle nach Variablen
            teilscript = puzzleteil[i].GetComponent<Puzzleteil_Bewegung>();
            immerFeld = container[i].GetComponent<ContainerZaehler>();
            if (immerFeld.imFeld == true && teilscript.touchi_touchi == true)
            {
            anzahlRichtige++;
            }
            if (anzahlRichtige == anzahlPuzzleTeile)
            {

               
                 

            }
        }
    }
}

