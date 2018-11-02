using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvester : MonoBehaviour {

    public static Harvester cl_Harvester;


    public GameObject go_Harvester;
    public Rigidbody2D rb_Harvester;
    public GameObject go_HarvesterGun;
    
    public Transform harvesterTransform;
    public Vector3 v3_Harvester;

    public GameObject target1Energy;
    public GameObject target2Res;

    public Transform energyTransformTarget1;
    public Transform resTransformTarget2;

    private float f_chaseRange = 30f;
    public float f_speed = 2;
    private float f_rotationSpeed = 5f;

    private float f_random;
    public bool b_IsBusy = false;
    public bool b_IsWorking = false;
    public bool b_IsFolowingToEnergy = false;
    public bool b_IsFolowingToRes = false;


    public void setSpeed(float newSpeed)
    {
        f_speed = newSpeed;
    }

    void Start () {

        cl_Harvester = this;

        if (this.gameObject.name == "harvester1")
        {
            cl_Harvester = this;
        }
        if (this.gameObject.name == "harvester2")
        {
            cl_Harvester = this;
        }
        if (this.gameObject.name == "harvester3")
        {
            cl_Harvester = this;
        }
        if (this.gameObject.name == "harvester4")
        {
            cl_Harvester = this;
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "unknownRes")

        {
            f_speed = 0;
            UnknownRes.cl_UnknownRes.b_IsCollecting = true;
            Debug.Log("HARVESTER TOUCH RES");
        }
    }


    private void FixedUpdate()
    {

        float distanceToTarget1 = Vector3.Distance(transform.position, energyTransformTarget1.position);
        float distanceToTarget2 = Vector3.Distance(transform.position, resTransformTarget2.position);

        if (distanceToTarget1 < f_chaseRange && distanceToTarget1 < distanceToTarget2 && b_IsWorking == false)
        {
           
            Vector3 targetDir = energyTransformTarget1.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        
       /* if (distanceToTarget2 < f_chaseRange && distanceToTarget2 < distanceToTarget1 && b_IsWorking == false)
        {
            

            Vector3 targetDir = resTransformTarget2.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }

        */


    }

    

    void Update () {

        if (b_IsWorking == false)
        {

            
        }
        if (b_IsWorking == true)
        {
            rb_Harvester.velocity = Vector3.zero;
        }
    }
}
