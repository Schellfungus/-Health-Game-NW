using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abfrage : MonoBehaviour
{
    public GameObject text, textFR, sanSalvador;
    public string[] moeglicheTasten;

    public Text display, puZaehler, timerB;
    public Button ausDerAsche;
    public Knopfaugen langeNase;

    public string aktuelleTaste;
    public int punkteUso;
    public float timerA;
    public bool spielenWir = true, gewonnen;
    // Start is called before the first frame update
    void Awake()
    {
        text = GameObject.Find("DisplayUI");
        sanSalvador = GameObject.Find("Restart");
        langeNase = sanSalvador.GetComponent<Knopfaugen>();

        //ausDerAsche = text.GetChild("Restart");
        //knoepfchen = ausDerAsche.GetComponent<Knoepfchen>;
        //textFR = Instantiate(text);
        //text.getChild().GetComponent<TextMeshPro - text UI> () = 1;

        anfang();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerA >0)
        {
            timerA -= Time.deltaTime;
            timerA = Mathf.Round(timerA * 100.0f) * 0.01f;
            timerB.text = timerA.ToString();


            if (Input.GetKeyDown(aktuelleTaste))
            {
                punkteUso++;
                bisschenWuerfeln();
            }
            else for (int i = 0; i < 8; i++)
                {
                    if (Input.GetKeyDown(moeglicheTasten[i]))
                    {
                        punkteUso--;
                        if (punkteUso < 0)
                        {
                            punkteUso = 0;
                        }
                        bisschenWuerfeln();
                    }
                }
        }
        else
        {
            spielenWir = false;
        }
        if ( spielenWir == false )
        {
            if (punkteUso > 30)
            {
                gewonnen = true;
            }
            else
            {
                langeNase.verstecken(true);
            }

        }
        if (langeNase.neustart == true)
        {
            anfang();
            langeNase.neustart = false;
        }
    } 

    public void bisschenWuerfeln()
    {
        aktuelleTaste = moeglicheTasten[Random.Range(0, 9)];
        display.text = aktuelleTaste;
        puZaehler.text = punkteUso.ToString();
    }

    public void anfang()
    {
        langeNase.verstecken(false);
        bisschenWuerfeln();
        timerA = 60;
    }
     
}
