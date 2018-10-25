using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStationLevel3 : MonoBehaviour {


    public GameObject go_MainStationLevel3;


    void Start () {
		
	}
	

	void Update () {
        go_MainStationLevel3.transform.Rotate(new Vector3(0, -0.025f, 0), Space.World);
    }
}
