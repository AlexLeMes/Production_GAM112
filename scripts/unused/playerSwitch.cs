using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSwitch : MonoBehaviour {

    public GameObject playerOne;
    public GameObject playerTwo;

    private playerController p1Script;
    private playerController p2Script;

    public GameObject playerOneCam;
    public GameObject playerTwoCam;

    private void Awake()
    {
        p1Script = playerOne.GetComponent<playerController>();
        p2Script = playerTwo.GetComponent<playerController>();
    }


    private void Start()
    {
        playerOneCam.SetActive(true);

        playerTwoCam.SetActive(false);
        p2Script.enabled = false;
    }

    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            enablePlayerOne();
            p1Script.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            enablePlayerTwo();
            p2Script.enabled = true;
        }
    }


    void enablePlayerOne()
    {
        playerTwoCam.SetActive(false);
        playerOneCam.SetActive(true);

        p2Script.enabled = false;
    }

    void enablePlayerTwo()
    {
        playerOneCam.SetActive(false);
        playerTwoCam.SetActive(true);

        p1Script.enabled = false;
    }
}
