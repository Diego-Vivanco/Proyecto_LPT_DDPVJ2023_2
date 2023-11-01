using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    public int numeroOro;
    public int numBronce;
    // Start is called before the first frame update
    void start()
    {
 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="oro")
        {

            Destroy(other.gameObject);
            numeroOro++;
            Debug.Log("Número cajas de oro: " + numeroOro);
        }

        if (other.tag == "bronce")
        {
            Destroy(other.gameObject);
            numBronce++;
            Debug.Log("Número de cajas de bronce: " + numBronce);



        }
    }
}
