using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoot : MonoBehaviour
{

    public PlayerPegaso playerPegaso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

        playerPegaso.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)  
    {
        playerPegaso.puedoSaltar = false;
    }
}
