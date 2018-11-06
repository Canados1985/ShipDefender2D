using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsairContainer : MonoBehaviour {

    public static CorsairContainer cl_CorsairContainer;

    public GameObject go_CorsairContainer;

    public Transform corsairContainerTransform;
    public Transform MainShipTransform;


    void Start () {
        cl_CorsairContainer = this;
    }
	
	
	void Update () {

        corsairContainerTransform.position = new Vector3(MainShipTransform.position.x, MainShipTransform.position.y, MainShipTransform.position.z + 5);

    }
}
