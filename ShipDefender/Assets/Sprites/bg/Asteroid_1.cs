using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_1 : MonoBehaviour {


    public GameObject go_Asteroid1;



	void Start () {

        go_Asteroid1 = GameObject.Find("asteroid1");

        if (this.gameObject.name != "asteroid1")
        {
            go_Asteroid1.transform.Rotate ( new Vector3 (90,90, 0), Space.World);
        }

    }
	
	
	void Update () {

        if (this.gameObject.name != "asteroid1")
        {
            go_Asteroid1.transform.Translate(new Vector3(-0.005f, 0, 0));
        }

         
    }
}
