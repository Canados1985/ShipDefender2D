using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour {

    public static ufo cl_ufo;

    public GameObject go_ufo;



	void Start () {
		
	}


    private void OnCollisionEnter(Collision col)
    {

            if (col.gameObject.tag == "missle")

            {
                Debug.Log("MISSLE HITS UFO");
            }
 
    }

    void Update () {
		
	}
}
