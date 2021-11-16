using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public Transform target;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
        	transform.LookAt(target);
            transform.Translate(new Vector3(10.0f * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        	transform.LookAt(target);
            transform.Translate(new Vector3(-10.0f * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
        	transform.LookAt(target);
            transform.Translate(new Vector3(0, -10.0f * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
        	transform.LookAt(target);
            transform.Translate(new Vector3(0, 10.0f * Time.deltaTime, 0));
        }

    }

}
