using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject menu_Inicial;
    public GameObject menu_Ajustes;
    public GameObject menu_Creditos;
    // Start is called before the first frame update
    void Start()
    {
        showMain();
    }

    public void showCredits()
    {
        CleanPanels();
        menu_Creditos.SetActive(true);
    }
    public void showOptions()
    {
        CleanPanels();
        menu_Ajustes.SetActive(true);
    }

    public void showMain()
    {
        CleanPanels();
        menu_Inicial.SetActive(true);
    }
    private void CleanPanels()
    {
        menu_Inicial.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

}
