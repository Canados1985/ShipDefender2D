using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_Asteroid : MonoBehaviour {

    public static SP_Asteroid cl_SP_Asteroid;

    public GameObject go_SP_Asteroid;
    public Transform SP_AsteroidTransform;

    private Vector3 v3_SP_Asteroid;

    public GameObject asteroid_1Inst;
    public GameObject astoroid_2Inst;


    private int i_counterAsteroid1;
    private int i_counterAsteroid2;

    private bool b_turnBack = false;


    private void Awake()
    {
        i_counterAsteroid1 = 100;
    }

    void Start () {

        go_SP_Asteroid = GameObject.Find("SP_Asteroid");
        SP_AsteroidTransform = go_SP_Asteroid.GetComponent<Transform>();


        go_SP_Asteroid.transform.Translate(new Vector3(25, 0, 0));
    }


    private void FixedUpdate()
    {
        i_counterAsteroid1--;

        if (i_counterAsteroid1 <= 0 )
        {

            Instantiate(asteroid_1Inst, v3_SP_Asteroid, new Quaternion(0, 0, 0, 90));
            i_counterAsteroid1 = 100;
        }
    }


    void Update () {

        if (SP_AsteroidTransform.position.z > 10f)

        {
            b_turnBack = true;
        }

        if (SP_AsteroidTransform.position.z < -10f)

        {
            b_turnBack = false;
        }

        if (b_turnBack) { go_SP_Asteroid.transform.Translate(new Vector3(0, 0, -0.05f)); }
        if (!b_turnBack) { go_SP_Asteroid.transform.Translate(new Vector3(0, 0, 0.05f)); }


        v3_SP_Asteroid.x = SP_AsteroidTransform.position.x;
        v3_SP_Asteroid.y = SP_AsteroidTransform.position.y;
        v3_SP_Asteroid.z = SP_AsteroidTransform.position.z;

	}
}
