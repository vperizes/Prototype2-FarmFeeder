using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static MainMenu _mMenu;
    public Button easyButton, mediumButton, hardButton;

    public bool isEasy;
    public bool isMedium;
    public bool isHard;

    //singleton pattern to call in spawn manager
    public void Awake()
    {
        _mMenu = this;
    }

    void Start()
    {
        easyButton.onClick.AddListener(PlayEasy);
        mediumButton.onClick.AddListener(PlayMedium);
        hardButton.onClick.AddListener(PlayHard);
    }
    public void PlayEasy()
    {
        SceneManager.LoadScene("Farm Feeder");
        isEasy = true;

    }

    public void PlayMedium()
    {
        SceneManager.LoadScene("Farm Feeder");
        isMedium = true;

    }

    public void PlayHard()
    {
        SceneManager.LoadScene("Farm Feeder");
        isHard = true;

    }

}
