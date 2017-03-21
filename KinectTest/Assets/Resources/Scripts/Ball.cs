using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public enum BallStates { Idle, Active };
    BallStates ballState = BallStates.Idle;

    public GameObject cube;
    public Vector3 movementVector;
    public float baseSpeed;
    float currentSpeed;
    float currentZ;

    Transform myPaddleTrans;

    void Awake()
    {
        currentZ = transform.position.z;
        Debug.Log(currentZ);
    }

    void Start()
    {
        myPaddleTrans = GameObject.FindGameObjectWithTag("Paddle").transform;
        movementVector = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (ballState == BallStates.Idle)
        {
            currentSpeed = baseSpeed;
            transform.position = myPaddleTrans.position + new Vector3(0, myPaddleTrans.localScale.y / 2 + transform.localScale.y / 2, 0);

            if (cube.transform.localScale.x < 3)
            {
                ballState = BallStates.Active;
                movementVector = new Vector3(currentSpeed, currentSpeed, 0);
            }
        }

        if (ballState == BallStates.Active)
        {
            transform.position += movementVector * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        movementVector = Vector3.Reflect(movementVector, col.contacts[0].normal);
        movementVector += movementVector.normalized * 0.2f;
    }
}
