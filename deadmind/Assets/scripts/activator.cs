using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour {

    public GameObject objectToActivate;

    void Awake()
    {
        objectToActivate.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            objectToActivate.SetActive(true);
            Destroy(gameObject);
        }
    }
}
