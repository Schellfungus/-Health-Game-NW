using UnityEngine;
using Cinemachine;

// Simeon
public class Spawnen : MonoBehaviour
{
    public GameObject spielerPrefab;
    public GameObject loadingzonePrefab;
    public GameObject kameraPrefab;

    public string letzterScreen;

    private Screen_Wechsel screen_Wechsel;
    private CinemachineVirtualCamera kameraComponente;

    // Wenn dieses Skript aktiviert wird
    private void OnEnable()
    {
        // Instantiate-Operationen
        GameObject spieler = Instantiate(spielerPrefab);
        GameObject scenenWechselTrigger = Instantiate(loadingzonePrefab);
        GameObject screenKam = Instantiate(kameraPrefab);

        // Finde die existierende Loading Zone (falls es eine gibt)
        GameObject existingLoadingZone = GameObject.Find("ScreenTransition(Clone)");
        if (existingLoadingZone != null)
        {
            loadingzonePrefab = existingLoadingZone;
            screen_Wechsel = existingLoadingZone.GetComponent<Screen_Wechsel>();
        }
        else
        {
            Debug.LogWarning("Keine vorhandene ScreenTransition gefunden.");
        }

        // Überprüfe, ob die Referenz erfolgreich ist
        if (screen_Wechsel == null)
        {
            Debug.LogError("Screen_Wechsel-Komponente nicht gefunden.");
        }
        else
        {
            // Fülle die Referenzen in der Screen_Wechsel-Komponente
            screen_Wechsel.refferenzenFuellen(spieler, "Screen_1");
        }

        // Finde die existierende Kamera (falls es eine gibt)
        kameraComponente = screenKam.GetComponent<CinemachineVirtualCamera>();

        // Überprüfe, ob die Referenz erfolgreich ist
        if (kameraComponente == null)
        {
            Debug.LogError("CinemachineVirtualCamera-Komponente nicht gefunden.");
        }
    }
}
