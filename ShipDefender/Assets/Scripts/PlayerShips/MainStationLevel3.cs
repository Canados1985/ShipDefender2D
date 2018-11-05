using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStationLevel3 : MonoBehaviour {


    public GameObject go_MainStationLevel3;

    public Transform mainstationLevel3Transform;

    void Start () {
		
	}
	

	void Update () {

       // if()
        go_MainStationLevel3.transform.Rotate(new Vector3(0, 0, 0.25f), Space.World);

        //go_MainStationLevel3.transform.Rotate(new Vector3(0, 0, -0.5f), Space.World);
    }
}
