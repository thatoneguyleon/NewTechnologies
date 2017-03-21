using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseKinectBody : MonoBehaviour
{
    public GameObject cube;
    //private List<string> BodyPartsLeft;
    //private List<string> BodyPartsRight;

    void Start()
    {
        //BodyPartsLeft = new List<string>() {"ShoulderLeft", "ElbowLeft", "WristLeft", "HandLeft", "HipLeft", "KneeLeft", "AnkleLeft", "FootLeft"};
        //BodyPartsRight = new List<string>() {"ShoulderRight", "ElbowRight", "WristRight", "HandRight", "HipRight", "KneeRight", "AnkleRight", "FootRight"};
    }

    void Update()
    {
        GameObject[] AllGameObjects = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[];
        for(int i = 0; i < AllGameObjects.Length; i++) {
            if (AllGameObjects[i].name.Contains("Body:")) {
                MakePlatform();
            }
        }
    }

    void MakePlatform() {        
        if(GameObject.Find("HandLeft") && GameObject.Find("HandRight")) {
            Vector3 HandLeft;
            Vector3 HandRight;
            HandLeft = GameObject.Find("HandLeft").transform.position;
            HandRight = GameObject.Find("HandRight").transform.position;

            Vector3 tLeftHand = new Vector3(HandLeft.x, HandRight.y - 15, 0);
            Vector3 tRightHand = new Vector3(HandRight.x, HandRight.y - 15, 0);

            Vector3 center = Vector3.Lerp(tLeftHand, tRightHand, 0.5f);
            float distance = Vector3.Distance(tLeftHand, tRightHand);
            float mappedPosX = ExtensionMethods.Map(center.x, -11, 11, -50, 50);
            float mappedPosY = ExtensionMethods.Map(center.y, -6, -16, -3, -16);

            cube.transform.position = new Vector3(mappedPosX, center.y, center.z + cube.GetComponent<Paddle>().currentZ);
            cube.transform.localScale = new Vector3(distance, cube.transform.localScale.y, 1);
        }
        
    }
}