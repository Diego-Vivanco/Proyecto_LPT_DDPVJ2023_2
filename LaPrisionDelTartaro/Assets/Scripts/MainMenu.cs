using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject menu_Inicial;
    //public GameObject menu_Ajustes;
    public GameObject menu_Creditos;
    // Start is called before the first frame update
    public GameObject menu_Ajustes;

    public Button playButton;
    public Button optionsButton;
    public Button creditsButton;
    public Button exitButton;
    public Button backFromOptionsButton;
    public Button backFromCreditsButton;

    void Start()
    {
        menu_Ajustes.SetActive(false);
        playButton.onClick.AddListener(PlayGame);
        creditsButton.onClick.AddListener(showCredits);
        optionsButton.onClick.AddListener(showOptions);
        backFromCreditsButton.onClick.AddListener(showMain);
        backFromOptionsButton.onClick.AddListener(showMain);
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
        //SoundMusicManager.InstanceMusic.PlayMenuAjustes();
    }

    public void showMain()
    {
        CleanPanels();
        menu_Inicial.SetActive(true);
        //SoundMusicManager.InstanceMusic.PlayMainMenu();


    }
    private void CleanPanels()
    {
        menu_Inicial.SetActive(false);
        menu_Ajustes.SetActive(false);
        menu_Creditos.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

}
