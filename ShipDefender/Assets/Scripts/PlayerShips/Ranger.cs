using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : MonoBehaviour {

    public static Ranger cl_Ranger;

    public GameObject go_Ranger;

    public Transform rangerTransform;


    private float f_counter;

    private bool b_IsLaunched = false;

	void Start () {

        cl_Ranger = this;
        go_Ranger = GameObject.Find("ranger");
        rangerTransform = go_Ranger.GetComponent<Transform>();

    }

    private void OnEnable()
    {
        f_counter = 2;
        //missleTransform.position = rangerTransform.position;
    }

    private void Disable()
    {
       
    }

    void MissleLaunch()
    {
        GameManager.cl_GameManager.LaunchMissle();
    }


	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {

        if(go_Ranger.activeSelf == true)
        f_counter -= Time.deltaTime;
             


            if (f_counter <= 0 && b_IsLaunched == false)
            {
                f_counter = 2;
                b_IsLaunched = true;

                MissleLaunch();
            }
            else if (f_counter < 1f)
            {
                b_IsLaunched = false;
            }
     


        Debug.Log(f_counter);
    }
}
