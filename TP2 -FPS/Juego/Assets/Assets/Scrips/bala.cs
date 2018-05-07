using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rigBala;
	void Start () {
        //rigBala.AddRelativeForce(Vector3.forward * -50, ForceMode.Impulse);
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(arma._cameraLookingAt * 50, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
