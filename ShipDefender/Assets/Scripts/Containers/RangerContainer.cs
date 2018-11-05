using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerContainer : MonoBehaviour {

    public static RangerContainer cl_RangerContainer;

    public GameObject go_RangerContainer;

    public Transform rangerContainerTransform;
    public Transform MainShipTransform;



	void Start () {
        cl_RangerContainer = this;

    }
	
	
	void Update () {

        rangerContainerTransform.position = new Vector3 (MainShipTransform.position.x , MainShipTransform.position.y, MainShipTransform.position.z + 5);

    }
}
