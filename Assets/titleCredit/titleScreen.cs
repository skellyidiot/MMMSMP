using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("SWITCH");
            SceneManager.LoadScene("actualPlatformer");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("EXIT");
            Application.Quit();
        }
    }
}
