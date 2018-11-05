using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipExplosion : MonoBehaviour {

    public GameObject go_ShipExplosion;

    private float f_counter = 0.8f;

	void Start () {
		
	}

    private void FixedUpdate()
    {
        f_counter -= Time.deltaTime;
    }


    void Update () {

        if (f_counter <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
