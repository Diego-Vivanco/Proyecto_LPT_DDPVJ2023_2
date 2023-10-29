using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    public string fileName;
    private StreamWriter sw;
    private StreamReader sr;
    private string fileContent;
    private Datos datos;

    private int numeroOro;
    private int numBronce;
    // Start is called before the first frame update
    void start()
    {
        Debug.Log(Application.persistentDataPath);
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="oro")
        {

            Destroy(other.gameObject);
            numeroOro++;
            Debug.Log("Número cajas de oro: " + numeroOro);

            //datos.numOro = numeroOro;
            datos.SetOro(numeroOro);
            sw = new StreamWriter(fileName, false);
            fileContent = JsonUtility.ToJson(datos); //Mandar un objeto cuya clase sea Serializable
            sw.Write(fileContent);
            sw.Close();


        }

        if (other.tag == "bronce")
        {
            Destroy(other.gameObject);
            numBronce++;
            Debug.Log("Número de cajas de bronce: " + numBronce);

            //datos.numPlata = numBronce;
            datos.SetPlata(numBronce);
            sw = new StreamWriter(fileName, false);
            fileContent = JsonUtility.ToJson(datos); //Mandar un objeto cuya clase sea Serializable
            sw.Write(fileContent);
            sw.Close();



        }
    }
}
