using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadArms : MonoBehaviour
{
    public GameObject interfazHUD;

    public TextMeshProUGUI armasRecolectadas;
    public TextMeshProUGUI cajasOro;
    public TextMeshProUGUI cajasBronce;




    public GameObject[] armas;
    private int contadorArmas;
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
        contadorArmas = contadorArmas + 1;
        Debug.Log("Numero de armas: " + contadorArmas);
        SetArmas(contadorArmas);
    }

    public void desactivaArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }

    public void SetArmas(int numeroArmas)
    {
        armasRecolectadas.text = numeroArmas.ToString();
    }
}
