using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvester : MonoBehaviour {

    public GameObject go_Harvester;
    public Rigidbody2D rb_Harvester;
    public GameObject go_HarvesterGun;

    public GameObject go_flame1;
    public GameObject go_flame2;
    public GameObject go_flame3;
    public GameObject go_flame4;

    public Transform harvesterTransform;
    public Vector3 v3_Harvester;

    public GameObject target1Energy;
    public GameObject target2Res;
    public GameObject target3Point1;
    public GameObject target4Point2;

    public Transform energyTransformTarget1;
    public Transform resTransformTarget2;
    public Transform point1TransformTarget;
    public Transform point2TransformTarget;
    

    private float f_chaseRange = 30f;
    public float f_speed = 2;
    private float f_rotationSpeed = 5f;

    private float f_random;
    public bool b_IsBusy = false;
    public bool b_IsWorking = false;

    public bool b_IsFolowingToEnergy = false;
    public bool b_IsFolowingToRes = false;
    public bool b_IsMovingToPoint1 = true;
    public bool b_IsMovingToPoint2 = false;


    public void setSpeed(float newSpeed)
    {
        f_speed = newSpeed;
    }

    void Start () {

       

        if (this.gameObject.name == "harvester1")
        {
            
            go_Harvester = GameObject.Find("harvester1");
            rb_Harvester = go_Harvester.GetComponent<Rigidbody2D>();
            target3Point1 = GameObject.Find("pointHarvester1");
            point1TransformTarget = target3Point1.GetComponent<Transform>();
            target4Point2 = GameObject.Find("pointHarvester2");
            point2TransformTarget = target4Point2.GetComponent<Transform>();

        }
        if (this.gameObject.name == "harvester2")
        {
           
            go_Harvester = GameObject.Find("harvester2");
            rb_Harvester = go_Harvester.GetComponent<Rigidbody2D>();
            target3Point1 = GameObject.Find("pointHarvester1");
            point1TransformTarget = target3Point1.GetComponent<Transform>();
            target4Point2 = GameObject.Find("pointHarvester2");
            point2TransformTarget = target4Point2.GetComponent<Transform>();
        }
        if (this.gameObject.name == "harvester3")
        {
           
            go_Harvester = GameObject.Find("harvester3");
            rb_Harvester = go_Harvester.GetComponent<Rigidbody2D>();
            target3Point1 = GameObject.Find("pointHarvester1");
            point1TransformTarget = target3Point1.GetComponent<Transform>();
            target4Point2 = GameObject.Find("pointHarvester2");
            point2TransformTarget = target4Point2.GetComponent<Transform>();
        }
        if (this.gameObject.name == "harvester4")
        {
            
            go_Harvester = GameObject.Find("harvester4");
            rb_Harvester = go_Harvester.GetComponent<Rigidbody2D>();
            target3Point1 = GameObject.Find("pointHarvester1");
            point1TransformTarget = target3Point1.GetComponent<Transform>();
            target4Point2 = GameObject.Find("pointHarvester2");
            point2TransformTarget = target4Point2.GetComponent<Transform>();
        }
    }



    private void FixedUpdate()
    {

        float distanceToTarget1 = Vector3.Distance(transform.position, energyTransformTarget1.position);
        float distanceToTarget2 = Vector3.Distance(transform.position, resTransformTarget2.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, point1TransformTarget.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, point2TransformTarget.position);


        // Harvester Behavior -->
        //Moving to Harvester Point 1
        if (Vector2.Distance(transform.position, point1TransformTarget.position) > 0.5f && b_IsMovingToPoint1 == true && b_IsFolowingToEnergy == false && b_IsFolowingToRes == false)
        {


            Vector3 targetDir = point1TransformTarget.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);


        }
        if (Vector2.Distance(transform.position, point1TransformTarget.position) <= 0.5f) { b_IsMovingToPoint1 = false; b_IsMovingToPoint2 = true; }

        //Moving to Harvester Point 2
        if (Vector2.Distance(transform.position, point2TransformTarget.position) > 0.5f && b_IsMovingToPoint2 == true && b_IsFolowingToEnergy == false && b_IsFolowingToRes == false)
        {


            Vector3 targetDir = point2TransformTarget.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);


        }
        if (Vector2.Distance(transform.position, point2TransformTarget.position) <= 0.5f) { b_IsMovingToPoint1 = true; b_IsMovingToPoint2 = false; }


        bool energyIsBusyTemp = target1Energy.GetComponent<EnergyOnClick>().b_IsBusy;
        bool resIsBusyTemp = target2Res.GetComponent<UnknownRes>().b_IsBusy;

        // Following to Energy
        if (b_IsFolowingToEnergy == true && b_IsWorking == false && energyIsBusyTemp == false)
        {
           
            Vector3 targetDir = energyTransformTarget1.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        // Following to Resource
        if (b_IsFolowingToRes == true && b_IsWorking == false && resIsBusyTemp == false)
        {
 
            Vector3 targetDir = resTransformTarget2.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }

    }

      void Update () {

        if (b_IsWorking == false)
        {

            go_flame1.SetActive(true);
            go_flame2.SetActive(true);
            go_flame3.SetActive(true);
            go_flame4.SetActive(true);
        }
        if (b_IsWorking == true)
        {
            rb_Harvester.velocity = Vector3.zero;
            go_flame1.SetActive(false);
            go_flame2.SetActive(false);
            go_flame3.SetActive(false);
            go_flame4.SetActive(false);
        }
    }
}
