using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour {

    public GameObject deathUI;

    void Awake()
    {
        deathUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "killTrigger")
        {
            deathUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
