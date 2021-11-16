using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel1Animation : MonoBehaviour
{

	private bool aTob = true;
	public Transform rotationA;
	public Transform rotationB;

	public float time = 4.0f;
	private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
    	timer += Time.deltaTime;

    	if(timer > time) {
    		timer = 0;
    		aTob = !aTob;
    	}

    	float ratio = timer/time;

    	if(aTob) {
	    	transform.rotation = Quaternion.Lerp(rotationA.rotation, rotationB.rotation, ratio);
	    } else {
	    	transform.rotation = Quaternion.Lerp(rotationB.rotation, rotationA.rotation, ratio);
	    }
    }
}
