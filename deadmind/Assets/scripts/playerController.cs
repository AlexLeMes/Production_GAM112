using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour{


    public float speed = 25f;
    public float rotateSpeed = 55f;

	void Update ()
    {
		if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }
}
