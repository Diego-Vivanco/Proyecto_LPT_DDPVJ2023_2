using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicItems : MonoBehaviour
{
    public bool destuirConCursor;
    public bool destruirAutomatico;

    public int tipo;

    public PlayerPegaso playerPegaso;
    // Start is called before the first frame update
    void Start()
    {
        playerPegaso = GameObject.FindGameObjectWithTag("Pegasov1").GetComponent<PlayerPegaso>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                Debug.Log("Cajas de oro: " );
                break;
            case 2:
                Debug.Log("Cajas de bronce: ");
                break;
            default:
                Debug.Log("Sin efecto");
                break;
                
        }
    }
}
