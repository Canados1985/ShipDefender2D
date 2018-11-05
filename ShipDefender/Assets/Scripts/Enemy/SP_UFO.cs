using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_UFO : MonoBehaviour {

    public static SP_UFO cl_SP_UFO;

    public GameObject go_SP_UFO;
    public Transform SP_UFOTransform;

    public GameObject UFO1Inst;
    public GameObject UFO2Inst;
    public GameObject UFO3Inst;

    private Vector3 v3_SP_UFO;

    private bool b_turnBack = false;

    private float f_counter = 10f;

    void Start () {


    }




    private void FixedUpdate()
    {
        f_counter -= Time.deltaTime;
        //Debug.Log(f_counter);
        if (f_counter <= 0)
        {
            int i_random;
            i_random = Random.Range(0, 4);

            if (i_random == 1) { Instantiate(UFO1Inst, v3_SP_UFO, new Quaternion(0, 0, 0, 0)); f_counter = 10 + i_random; }
            if (i_random == 2) { Instantiate(UFO2Inst, v3_SP_UFO, new Quaternion(0, 0, 0, 0)); f_counter = 10 + i_random; }
            if (i_random == 3) { Instantiate(UFO3Inst, v3_SP_UFO, new Quaternion(0, 0, 0, 0)); f_counter = 10 + i_random; }


        }
    }

    void Update () {

        v3_SP_UFO.x = SP_UFOTransform.position.x;
        v3_SP_UFO.y = SP_UFOTransform.position.y;
        v3_SP_UFO.z = SP_UFOTransform.position.z;


        if (SP_UFOTransform.position.y > 30f)

        {
            b_turnBack = true;
        }
        
        if (SP_UFOTransform.position.y < -30f)

        {
            b_turnBack = false;
        }

        if (b_turnBack) { go_SP_UFO.transform.Translate(new Vector3(0, -0.05f, 0)); }
        if (!b_turnBack) { go_SP_UFO.transform.Translate(new Vector3(0, 0.05f, 0)); }

    }
}
