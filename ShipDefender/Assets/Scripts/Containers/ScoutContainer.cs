using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutContainer : MonoBehaviour {

    public static ScoutContainer cl_ScoutContainer;

    public GameObject go_ScoutContainer;

    public Transform scoutContainerTransform;
    public Transform MainShipTransform;


    void Start () {
        cl_ScoutContainer = this;
    }
	

	void Update () {

        scoutContainerTransform.position = new Vector3(MainShipTransform.position.x, MainShipTransform.position.y, MainShipTransform.position.z + 5);

    }
}
