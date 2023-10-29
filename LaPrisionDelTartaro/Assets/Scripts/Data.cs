using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using static UnityEditor.Experimental.GraphView.GraphView;


public class Data : MonoBehaviour
{

    public string fileName;
    private StreamWriter sw;
    private StreamReader sr;
    private string fileContent;
    private Datos datos;
    //private List<Player> players;

    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/" + fileName))
        {
            Debug.Log("El archivo ya existe");
            sr = new StreamReader(Application.persistentDataPath + "/" + fileName);
            Debug.Log(Application.persistentDataPath + "/" + fileName);
            fileContent = sr.ReadToEnd();
            Debug.Log("File Content" + fileContent);
            datos = new Datos();
            datos = JsonUtility.FromJson<Datos> (fileContent);
            //players = JsonUtility.FromJson<List<Player>>(fileContent);
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
            sw = new StreamWriter(fileName, false);
            fileContent = JsonUtility.ToJson(datos); //Mandar un objeto cuya clase sea Serializable
            sw.Write(fileContent);
            sw.Close();

            Debug.Log("Se creo el archivo");


 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Serializable]
    public class Datos
    {
        public int vidas;
        public int numArmas;
        public int numOro;
        public int numPlata;
        public int porcentajeVida;

    }


}
