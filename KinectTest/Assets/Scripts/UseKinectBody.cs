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
            if (AllGameObjects[i].name.Contains("Body:")) { // wanneer de kinect een lichaam herkend maakt hij een object aan met een naam waar het stuk "Body:" inzit, wanneer hij dat vind gaan we de paddle maken.
                MakePlatform();
            }
        }
    }

    void MakePlatform() {        
        if(GameObject.Find("HandLeft") && GameObject.Find("HandRight")) { // als we beide handen kunnen zien gaan we die posities gebruiken.
            Vector3 HandLeft;
            Vector3 HandRight;
            HandLeft = GameObject.Find("HandLeft").transform.position;
            HandRight = GameObject.Find("HandRight").transform.position;

            Vector3 tLeftHand = new Vector3(HandLeft.x, HandRight.y - 15, 0);
            Vector3 tRightHand = new Vector3(HandRight.x, HandRight.y - 15, 0);

            Vector3 center = Vector3.Lerp(tLeftHand, tRightHand, 0.5f); // we gebruiken een cube en hun pivot zit in de center.
            float distance = Vector3.Distance(tLeftHand, tRightHand);   // de distance tussen twee handen gebruiken we voor de length.
            float mappedPosX = ExtensionMethods.Map(center.x, -11, 11, -50, 50); // de world space is groter dan de real space, dus we moeten de positie mappen om de volledige breedte van de scene te benuttigen.
            float mappedPosY = ExtensionMethods.Map(center.y, -6, -16, -3, -16); // we willen wat force gebruiken dus deze mappen we ook een klein beetje zodat je niet je armen er af hoeft te gooien.

            cube.transform.position = new Vector3(mappedPosX, center.y, center.z + cube.GetComponent<Paddle>().currentZ);
            cube.transform.localScale = new Vector3(distance, cube.transform.localScale.y, 1);
        }
        
    }
}