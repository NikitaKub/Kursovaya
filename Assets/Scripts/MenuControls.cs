using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class StatParam
{
    public static string levelKey = "level";
}

public class MenuControls : MonoBehaviour
{

    private GameObject UIF;
    private GameObject UIEsc;

    [SerializeField] Button levelSecond;
    [SerializeField] Button levelThirst;
    [SerializeField] Button levelFourth;

    public void Awake()
    {
        this.UIF = GameObject.FindWithTag("Finish_Menu");
        this.UIEsc = GameObject.FindWithTag("Esc_Menu");

        if (PlayerPrefs.HasKey(StatParam.levelKey))
        {
            
        }
        else
        {
            PlayerPrefs.SetInt(StatParam.levelKey, 0);
        }

        InteractableLevels();

        
        this.UIF.SetActive(false);
        this.UIEsc.SetActive(false);
    }

    public void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            this.UIEsc.SetActive(false);
            this.UIF.SetActive(true);
        }
    }

    public void PlayPressed()
    {
        PlayerPrefs.SetInt(StatParam.levelKey, 0);
        LoadFirstScene();
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void LoadSecondScene()
    {
        SceneManager.LoadScene("Lvl2");
    }
    
    public void LoadThirtScene()
    {
        SceneManager.LoadScene("Lvl3");
    }

    public void LoadFourthScene()
    {
        SceneManager.LoadScene("Lvl4");
    }

    private void InteractableLevels()
    {
        if (PlayerPrefs.GetInt(StatParam.levelKey) >= 3)
        {
            levelSecond.interactable = true;
            levelThirst.interactable = true;
            levelFourth.interactable = true;
        }
        else if (PlayerPrefs.GetInt(StatParam.levelKey) == 2)
        {
            levelSecond.interactable = true;
            levelThirst.interactable = true;
            levelFourth.interactable = false;
        }
        else if (PlayerPrefs.GetInt(StatParam.levelKey) == 1)
        {
            levelSecond.interactable = true;
            levelThirst.interactable = false;
            levelFourth.interactable = false;
        }
        else if (PlayerPrefs.GetInt(StatParam.levelKey) == 0)
        {
            levelSecond.interactable = false;
            levelThirst.interactable = false;
            levelFourth.interactable = false;
        }
    }
}
