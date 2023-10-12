using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            }
        }
        
    }
}
