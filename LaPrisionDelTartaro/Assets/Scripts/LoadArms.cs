using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArms : MonoBehaviour
{
    public GameObject[] armas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            desactivaArmas();
        }
    }

    public void activaArmas(int numero)
    {
        for(int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
    }

    public void desactivaArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }
}
