using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caida : MonoBehaviour
{
    public int lifes = 3;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "vacio" && lifes == 0)
        {
            Debug.Log("JUEGO PERDIDO");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //lifes -= 1;
        }
        if(other.tag == "vacio" && lifes  > 0)
        {
            lifes-=1; ;
            Debug.Log("lifes: " + lifes);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
