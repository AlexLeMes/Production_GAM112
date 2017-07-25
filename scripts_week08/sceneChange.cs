using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

    public string sceneToChangeTo;

    bool canChange = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            canChange = true;
            changeSceneTo();
        }
    }

    public void changeSceneTo()
    {
        if(canChange == true)
        { 
            SceneManager.LoadScene(sceneToChangeTo);
        }
    }
}
