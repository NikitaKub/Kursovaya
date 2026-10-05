using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 modeDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().linearVelocity += modeDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().linearVelocity -= modeDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1 && PlayerPrefs.GetInt(StatParam.levelKey) == 0)
            {
                PlayerPrefs.SetInt(StatParam.levelKey, PlayerPrefs.GetInt(StatParam.levelKey) + 1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2 && PlayerPrefs.GetInt(StatParam.levelKey) == 1)
            {
                PlayerPrefs.SetInt(StatParam.levelKey, PlayerPrefs.GetInt(StatParam.levelKey) + 1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3 && PlayerPrefs.GetInt(StatParam.levelKey) == 2)
            {
                PlayerPrefs.SetInt(StatParam.levelKey, PlayerPrefs.GetInt(StatParam.levelKey) + 1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4 && PlayerPrefs.GetInt(StatParam.levelKey) == 3)
            {
                PlayerPrefs.SetInt(StatParam.levelKey, PlayerPrefs.GetInt(StatParam.levelKey) + 1);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
