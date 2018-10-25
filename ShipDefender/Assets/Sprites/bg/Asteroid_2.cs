using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_2 : MonoBehaviour {


    public GameObject go_Asteroid1;

    void Start () {

        go_Asteroid1 = GameObject.Find("asteroid2");

    }
	
	
	void Update () {

        if (this.gameObject.name != "asteroid2")
        {
            go_Asteroid1.transform.Translate(new Vector3(-0.005f, 0, 0));
        }

    }
}
