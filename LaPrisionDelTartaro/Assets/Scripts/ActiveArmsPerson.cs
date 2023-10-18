using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveArmsPerson : MonoBehaviour
{
    public LoadArms tomarArma;
    public int numArma;

    // Start is called before the first frame update
    void Start()
    {
        tomarArma = GameObject.FindGameObjectWithTag("Pegasov1").GetComponent<LoadArms>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pegasov1")
        {
            tomarArma.activaArmas(numArma);
            Destroy(gameObject);
        }
    }


}
