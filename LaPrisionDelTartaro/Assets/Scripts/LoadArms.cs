using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LoadArms : MonoBehaviour
{
    public string fileName;
    private StreamWriter sw;
    private StreamReader sr;
    private string fileContent;
    private Datos datos;

    //public GameObject interfazHUD;

    //public TextMeshProUGUI armasRecolectadas;
    //public TextMeshProUGUI cajasOro;
    //public TextMeshProUGUI cajasBronce;

    public GameObject[] armas;
    private int contadorArmas;
    // Start is called before the first frame update
    void Start()
    {

        //ruta = Application.persistentDataPath + "/" + fileName;
        if (File.Exists(Application.persistentDataPath + "/" + fileName))
        {
            Debug.Log("El archivo ya existe");
            sr = new StreamReader(/*Application.persistentDataPath + "/" +*/ fileName);
            Debug.Log(Application.persistentDataPath + "/" + fileName);
            fileContent = sr.ReadToEnd();
            //Debug.Log("File Content" + fileContent);
            datos = new Datos();
            datos = JsonUtility.FromJson<Datos>(fileContent);
            Debug.Log(datos.numArmas);
        }
        else
        {
            Debug.Log("No existe el archivo");
            datos = new Datos();
            datos.vidas = 3;
            datos.numArmas = 0;
            datos.numPlata = 0;
            datos.numOro = 0;
            datos.porcentajeVida = 100;

            Debug.Log("Se creo el archivo");

        }

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
        datos.vidas = contadorArmas;

        sw = new StreamWriter(fileName, false);
        fileContent = JsonUtility.ToJson(datos); //Mandar un objeto cuya clase sea Serializable
        sw.Write(fileContent);
        sw.Close();

        //SetArmas(contadorArmas);
    }

    public void desactivaArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }

    //public void SetArmas(int numeroArmas)
    //{
    //    armasRecolectadas.text = numeroArmas.ToString();
    //}
}
