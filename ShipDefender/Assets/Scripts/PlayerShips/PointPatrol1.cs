using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPatrol1 : MonoBehaviour {

    public GameObject go_pointPatrol1;


    public Transform rangerPointPatrol1Transform;


    private bool b_turnBack = false;

    float f_counter = 30f;

    

    void Start () {
		
	}
	
	

  
        void Update()
        {

            if (f_counter > 0)
            {
                f_counter -= Time.deltaTime;
            }
            if (f_counter <= 0)
            {
                int i_random;
                i_random = Random.Range(-17, 19);

             rangerPointPatrol1Transform.position = new Vector3(i_random, 10, 0);
            f_counter = 30 + i_random;
            }

        }

    
}
