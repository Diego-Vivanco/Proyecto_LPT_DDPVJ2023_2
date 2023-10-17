using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour
{

    public GameObject GrupoMenuPausa;

    public bool pausa = false;

    // Start is called before the first frame update
    void Start()
    {
        GrupoMenuPausa.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa == false)
            {
                GrupoMenuPausa.SetActive(true);
                pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }

    public void Reanudar()
    {
        GrupoMenuPausa.SetActive(false);
        pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }


    public void Reinicio()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Ajustes()
    {

    }

    public void LimpiarPaneles()
    {

    }

    public void irMenuInicio(string nombreMenu)
    {
        SceneManager.LoadScene(nombreMenu);
    }

}
