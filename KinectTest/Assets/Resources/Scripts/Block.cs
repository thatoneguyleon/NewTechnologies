using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.transform.tag == "Ball") {
			GetDestroyed ();
		}
	}

	void GetDestroyed(){
		Destroy (gameObject);
	}
}
