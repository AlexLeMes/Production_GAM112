using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public string currentScene;

    void retry()
    {
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1;
    }
}
