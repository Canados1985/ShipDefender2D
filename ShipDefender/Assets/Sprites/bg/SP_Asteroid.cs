using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_Asteroid : MonoBehaviour {

    public static SP_Asteroid cl_SP_Asteroid;



    public GameObject go_SP_Asteroid;
    public Transform SP_AsteroidTransform;

    private Vector3 v3_SP_Asteroid;


    public GameObject asteroid1Inst;
    public GameObject asteroid2Inst;
    public GameObject unknownResInst;


    public float f_counter;
   
    private bool b_turnBack = false;


    void Start() {

        f_counter = 10;

        go_SP_Asteroid = GameObject.Find("SP_Asteroid");
        SP_AsteroidTransform = go_SP_Asteroid.GetComponent<Transform>();

        SP_AsteroidTransform.position = new Vector3(55, SP_AsteroidTransform.position.y, SP_AsteroidTransform.position.z);

    }



    private void FixedUpdate()
    {
        f_counter -= Time.deltaTime; 


        if (f_counter <= 0 )
        {
  

            float f_random;
            f_random = Random.Range(0,2);

            if (f_random < 1)
            {
                Instantiate(asteroid1Inst, v3_SP_Asteroid, new Quaternion(0,0,0,0));
                //Debug.Log("LAUNCH ASTEROID 1");

                f_counter = 10 + f_random;
            }
            if (f_random > 1)
            {
                Instantiate(asteroid2Inst, v3_SP_Asteroid, new Quaternion(0, 0, 0, 0));
                //Debug.Log("LAUNCH ASTEROID 2");
                f_counter = 10 + f_random;
            }
            if (f_random == 1)
            {
                Instantiate(unknownResInst, v3_SP_Asteroid, new Quaternion(0, 0, 0, 0));
                f_counter = 10 + f_random;
            }

        }

    }


    void Update () {

        if (SP_AsteroidTransform.position.y > 20f)

        {
            b_turnBack = true;
        }

        if (SP_AsteroidTransform.position.y < -20f)

        {
            b_turnBack = false;
        }

        if (b_turnBack) { go_SP_Asteroid.transform.Translate(new Vector3(0, -0.05f, 0)); }
        if (!b_turnBack) { go_SP_Asteroid.transform.Translate(new Vector3(0, 0.05f, 0)); }


        v3_SP_Asteroid.x = SP_AsteroidTransform.position.x;
        v3_SP_Asteroid.y = SP_AsteroidTransform.position.y;
        v3_SP_Asteroid.z = SP_AsteroidTransform.position.z;

	}
}
