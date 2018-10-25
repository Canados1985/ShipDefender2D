using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStationLevel2 : MonoBehaviour {

    public GameObject go_MainStationLevel2;

	void Start () {
		
	}
	

	void Update () {

        go_MainStationLevel2.transform.Rotate(new Vector3(0, 0.05f, 0), Space.World);

    }
}
