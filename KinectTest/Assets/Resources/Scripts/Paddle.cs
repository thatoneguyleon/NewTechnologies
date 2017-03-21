using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    
    public float currentZ;
    Vector3 currentVector;
    Vector3 lastVector;
    Vector3 force;

    void Awake()
    {
        currentZ = transform.position.z;
        Debug.Log(currentZ);
    }

    void OnCollisionEnter(Collider col)
    {
        if(col.name == "Ball")
        {
            col.GetComponent<Rigidbody>().AddForce(force * 100);
            col.GetComponent<Ball>().movementVector += force * 10;
        }
    }

    void Update()
    {
        currentVector = transform.position;
        if(lastVector != null)
        {
            force = currentVector - lastVector;
            Debug.Log(force);
        }
        lastVector = transform.position;
    }
}
