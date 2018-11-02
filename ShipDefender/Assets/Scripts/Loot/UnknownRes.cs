using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnknownRes : MonoBehaviour {

    public static UnknownRes cl_UnknownRes;

    public GameObject go_UnknownRes;
    public Transform unknownResTransform;

    public bool b_IsCollecting = false;

    private float f_counter = 10f;

    void Start () {

        cl_UnknownRes = this;
        
    }


    private void FixedUpdate()
    {
        if (b_IsCollecting == true)
        {
            f_counter -= Time.deltaTime;
        }
        if (f_counter <= 0)
        {
            f_counter = 10f;
            Destroy(this.gameObject);
            
        }
    }


    void Update () {

        if (b_IsCollecting == false)
        {
            go_UnknownRes.transform.Translate(new Vector3(-0.0055f, 0, 0));
        }
        

    }
}
