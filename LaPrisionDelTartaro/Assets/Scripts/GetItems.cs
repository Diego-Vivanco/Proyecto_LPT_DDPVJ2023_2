using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    private int numOro;
    private int numBronce;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="oro")
        {

            Destroy(other.gameObject);
            numOro++;
            Debug.Log("N�mero cajas de oro: " + numOro);
        }

        if (other.tag == "bronce")
        {
            Destroy(other.gameObject);
            numBronce++;
            Debug.Log("N�mero de cajas de bronce: " + numBronce);

        }
    }
}
