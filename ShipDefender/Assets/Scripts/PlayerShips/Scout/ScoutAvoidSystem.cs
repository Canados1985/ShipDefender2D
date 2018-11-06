using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutAvoidSystem : MonoBehaviour {

   
    public bool b_avoidUFOAtack = false;

    float f_counter = 0.2f;

	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();

        if ((tempScout.gameObject.name == "scout1" && collision.gameObject.name == "laserUFO1") || (tempScout.gameObject.name == "scout1" && collision.gameObject.name == "laserUFO2") || (tempScout.gameObject.name == "scout1" && collision.gameObject.name == "laserUFO3"))
        {
            Debug.Log("AVOID SYSTEM WORKS!!!");

            b_avoidUFOAtack = true;
        }
    }




    private void FixedUpdate()
    {
        if (b_avoidUFOAtack == true)
        {
            f_counter -= Time.deltaTime;
        }
        if (f_counter <= 0)
        {
            b_avoidUFOAtack = false;
            f_counter = 0.2f;
        }
    }


    void Update () {




	}
}
