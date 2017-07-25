using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaver : MonoBehaviour {

    bool canUseLeaver;

    public GameObject objectToDeActivate;
    public GameObject leaverCanvas;

    void Awake ()
    {
        canUseLeaver = false;
        leaverCanvas.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "leaverTrigger")
        {
            leaverCanvas.SetActive(true);
            Debug.Log("user_uses_leaver");
            canUseLeaver = true;
        }
    }

    void Update()
    {
        if(canUseLeaver == true && Input.GetKey(KeyCode.E))
        {
            objectToDeActivate.SetActive(false);
        }
    }

}
