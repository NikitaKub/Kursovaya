using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueEsc : MonoBehaviour
{
    public bool escapeMenuActive;
    public GameObject UI;
    public GameObject MenuContinue;
    public GameObject Help;
    public GameObject Settings;

    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 5)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (escapeMenuActive == false)
                {
                    escapeMenuActive = true;
                    UI.gameObject.SetActive(false);
                    Help.gameObject.SetActive(false);
                    MenuContinue.gameObject.SetActive(true);
                    Settings.gameObject.SetActive(false);
                }
                else
                {
                    escapeMenuActive = false;
                    MenuContinue.gameObject.SetActive(false);
                    UI.gameObject.SetActive(true);
                    Help.gameObject.SetActive(false);
                    Settings.gameObject.SetActive(false);
                }
            }
            
            UI.GetComponentInChildren<Text>().text = "Lvl " + SceneManager.GetActiveScene().buildIndex;
        }
    }
    public void ContinuePressed()
    {
        escapeMenuActive = false;
        MenuContinue.gameObject.SetActive(false);
        UI.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
