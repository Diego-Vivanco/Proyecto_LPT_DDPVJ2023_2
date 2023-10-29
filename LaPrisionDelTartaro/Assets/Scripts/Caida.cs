using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caida : MonoBehaviour
{
    public int lifes = 3;
    public int cont = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "vacio")
        {
            while (lifes > 0)
            {
                lifes -= 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }

            Debug.Log("PERDISTE JUEGO");

        }


        //if(other.tag == "vacio")
        //{
        //    cont +=1;
        //    Debug.Log("Contador: "+ cont);
        //    if(cont == 3)
        //    {
        //        Debug.Log("JUEGO PERDIDO");
        //    }
        //    else
        //    {
        //        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //        lifes -= 1;
        //        Debug.Log("lifes: " + lifes);
        //    }
        //    //Debug.Log("JUEGO PERDIDO");
        //    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //    //lifes -= 1;
        //}


    }
}
