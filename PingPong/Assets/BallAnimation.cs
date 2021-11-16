using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{

	private bool aTob = true;

	public AnimationCurve curve;
	public Vector3 positionA;
	public Vector3 positionB;
	public Vector3 offset;

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

    	Vector3 positionOffset = curve.Evaluate(ratio) * offset;

    	if(aTob) {
	    	transform.position = Vector3.Lerp(positionA, positionB, ratio) + positionOffset;
	    } else {
	    	transform.position = Vector3.Lerp(positionB, positionA, ratio) + positionOffset;
	    }
    }
}
