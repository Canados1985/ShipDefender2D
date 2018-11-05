using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : MonoBehaviour {



    public GameObject go_Ranger;
    public Rigidbody2D rb_Ranger;
    private Vector3 v3_Ranger;
    public Transform RangerContainerTransform;

    public GameObject go_flame1;
    public GameObject go_flame2;

    public GameObject target1MainStation;
    public GameObject target2PointPatrol1;
    public GameObject target3PointPatrol2;
    public GameObject target4UFO1;
    public GameObject target5UFO2;
    public GameObject target6UFO3;
    public GameObject target7Asteroid1;
    public GameObject target8Asteroid2;


    public Transform pointPatrol1TransformTarget; //  point1 position
    public Transform pointPatrol2TransformTarget; //  point2 position
    public Transform mainStationTransformTarget; // Main station position
    public Transform ufo1TransformTarget; // UFO1 position
    public Transform ufo2TransformTarget; // UFO2 position
    public Transform ufo3TransformTarget; // UFO3 position
    public Transform asteroid1TransformTarget; // Asteroid1 position
    public Transform asteroid2TransformTarget; // Asteroid2 position

    private float f_chaseRange = 3f;

    public Transform rangerTransform;
    public Transform rangerGun1Transform;
    public Transform rangerGun2Transform;

    public GameObject missleRef;
    public GameObject go_shipExplosionInst;

    private float f_counterR1 = 5f;
    private float f_counterR2 = 5f;
    private float f_counterR3 = 5f;

    private float f_rotationSpeed = 2.5f; // Ranger Rotation speed
    private float f_speed = 3f; // Ranger Speed

    public bool b_IsLaunched_Ranger1 = false;
    public bool b_IsAimed_Ranger1 = false;
    public bool b_backOnBase_Ranger1 = false;

    public bool b_IsLaunched_Ranger2 = false;
    public bool b_IsAimed_Ranger2 = false;
    public bool b_backOnBase_Ranger2 = false;

    public bool b_IsLaunched_Ranger3 = false;
    public bool b_IsAimed_Ranger3 = false;
    public bool b_backOnBase_Ranger3 = false;

    public bool b_backOnBase = false;

    public bool b_movingToPatrolPoint1 = false;
    public bool b_movingToPatrolPoint2 = true;
    public bool b_movingBackToBase = false;
    public bool b_chasingUFO = false;
    public bool b_chasingAsteroid = false;


    public bool b_Gun1 = false;
    public bool b_Gun2 = false;


    void Start() {
      
        //Start and Set up load for Ranger 1
        if (this.gameObject.name == "ranger1")
        {
            go_Ranger = GameObject.Find("ranger1");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();
            RangerContainerTransform = RangerContainer.cl_RangerContainer.GetComponent<Transform>();

            target1MainStation = GameObject.Find("MainStation");
            mainStationTransformTarget = target1MainStation.GetComponent<Transform>();

            target2PointPatrol1 = GameObject.Find("pointPatrol1");
            pointPatrol1TransformTarget = target2PointPatrol1.GetComponent<Transform>();

            target3PointPatrol2 = GameObject.Find("pointPatrol2");
            pointPatrol2TransformTarget = target3PointPatrol2.GetComponent<Transform>();

            ufo1TransformTarget = target4UFO1.GetComponent<Transform>();
            ufo2TransformTarget = target5UFO2.GetComponent<Transform>();
            ufo3TransformTarget = target6UFO3.GetComponent<Transform>();
            asteroid1TransformTarget = target7Asteroid1.GetComponent<Transform>();
            asteroid2TransformTarget = target8Asteroid2.GetComponent<Transform>();



        }

        //Start and Set up load for Ranger 2
        if (this.gameObject.name == "ranger2")
        {
           
            go_Ranger = GameObject.Find("ranger2");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();
            RangerContainerTransform = RangerContainer.cl_RangerContainer.GetComponent<Transform>();

            target1MainStation = GameObject.Find("MainStation");
            mainStationTransformTarget = target1MainStation.GetComponent<Transform>();

            target2PointPatrol1 = GameObject.Find("pointPatrol1");
            pointPatrol1TransformTarget = target2PointPatrol1.GetComponent<Transform>();

            target3PointPatrol2 = GameObject.Find("pointPatrol2");
            pointPatrol2TransformTarget = target3PointPatrol2.GetComponent<Transform>();

            ufo1TransformTarget = target4UFO1.GetComponent<Transform>();
            ufo2TransformTarget = target5UFO2.GetComponent<Transform>();
            ufo3TransformTarget = target6UFO3.GetComponent<Transform>();
            asteroid1TransformTarget = target7Asteroid1.GetComponent<Transform>();
            asteroid2TransformTarget = target8Asteroid2.GetComponent<Transform>();

        }

        //Start and Set up load for Ranger 3
        if (this.gameObject.name == "ranger3")
        {
            go_Ranger = GameObject.Find("ranger3");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();
            RangerContainerTransform = RangerContainer.cl_RangerContainer.GetComponent<Transform>();

            target1MainStation = GameObject.Find("MainStation");
            mainStationTransformTarget = target1MainStation.GetComponent<Transform>();

            target2PointPatrol1 = GameObject.Find("pointPatrol1");
            pointPatrol1TransformTarget = target2PointPatrol1.GetComponent<Transform>();

            target3PointPatrol2 = GameObject.Find("pointPatrol2");
            pointPatrol2TransformTarget = target3PointPatrol2.GetComponent<Transform>();

            ufo1TransformTarget = target4UFO1.GetComponent<Transform>();
            ufo2TransformTarget = target5UFO2.GetComponent<Transform>();
            ufo3TransformTarget = target6UFO3.GetComponent<Transform>();
            asteroid1TransformTarget = target7Asteroid1.GetComponent<Transform>();
            asteroid2TransformTarget = target8Asteroid2.GetComponent<Transform>();
        }

    }

    


    void DestroyRanger()
    {
        go_Ranger.SetActive(false);
        rangerTransform.position = RangerContainerTransform.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ENEMYBULLET")
        {
            FindObjectOfType<AudioManager>().Play("shipExplosion");
            DestroyRanger();
        }

    }



    void FixedUpdate()
    {


        if (b_IsAimed_Ranger1 == true || b_IsAimed_Ranger2 == true || b_IsAimed_Ranger3 == true)
        {
            f_counterR1 -= Time.deltaTime;
            f_counterR2 -= Time.deltaTime;
            f_counterR3 -= Time.deltaTime;
            if (f_counterR1 <= 0 && b_IsAimed_Ranger1 == true) { b_IsAimed_Ranger1 = false; f_counterR1 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
            if (f_counterR2 <= 0 && b_IsAimed_Ranger2 == true) { b_IsAimed_Ranger2 = false; f_counterR2 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
            if (f_counterR3 <= 0 && b_IsAimed_Ranger3 == true) { b_IsAimed_Ranger3 = false; f_counterR3 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
        }



        float distanceToTarget2 = Vector3.Distance(transform.position, pointPatrol1TransformTarget.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, pointPatrol2TransformTarget.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, ufo1TransformTarget.position);
        float distanceToTarget5 = Vector3.Distance(transform.position, ufo2TransformTarget.position);
        float distanceToTarget6 = Vector3.Distance(transform.position, ufo3TransformTarget.position);


    // Rangers Behavior --->
        if (this.gameObject.name == "ranger1")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Ranger1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Ranger1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Ranger1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Ranger1 == false && b_chasingAsteroid == false)
            {

                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsUFO1 == true)
                {
                    Vector3 targetDir = ufo1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO2 == true)
                {
                    Vector3 targetDir = ufo2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO3 == true)
                {
                    Vector3 targetDir = ufo3TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

            }
            //Chasing Asteroid
            if (b_chasingUFO == false && b_IsAimed_Ranger1 == false && b_chasingAsteroid == true)
            {
                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsAsteriod1 == true)
                {
                    Vector3 targetDir = asteroid1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

                if (tempSensor.b_colIsAsteroid2 == true)
                {
                    Vector3 targetDir = asteroid2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
            }

        }
        if (this.gameObject.name == "ranger2")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Ranger2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Ranger2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Ranger2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Ranger2 == false && b_chasingAsteroid == false)
            {
                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsUFO1 == true)
                {
                    Vector3 targetDir = ufo1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO2 == true)
                {
                    Vector3 targetDir = ufo2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO3 == true)
                {
                    Vector3 targetDir = ufo3TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

            }
            //Chasing Asteroid
            if (b_chasingUFO == false && b_IsAimed_Ranger2 == false && b_chasingAsteroid == true)
            {
                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsAsteriod1 == true)
                {
                    Vector3 targetDir = asteroid1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

                if (tempSensor.b_colIsAsteroid2 == true)
                {
                    Vector3 targetDir = asteroid2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
            }

        }
        if (this.gameObject.name == "ranger3")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Ranger3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Ranger3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Ranger3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Ranger3 == false && b_chasingAsteroid == false)
            {
                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsUFO1 == true)
                {
                    Vector3 targetDir = ufo1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO2 == true)
                {
                    Vector3 targetDir = ufo2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
                if (tempSensor.b_colIsUFO3 == true)
                {
                    Vector3 targetDir = ufo3TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

            }
            //Chasing Asteroid
            if (b_chasingUFO == false && b_IsAimed_Ranger3 == false && b_chasingAsteroid == true)
            {
                RangerSensor tempSensor = gameObject.transform.GetComponentInChildren<RangerSensor>();
                if (tempSensor.b_colIsAsteriod1 == true)
                {
                    Vector3 targetDir = asteroid1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }

                if (tempSensor.b_colIsAsteroid2 == true)
                {
                    Vector3 targetDir = asteroid2TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);
                }
            }

        }



    }



    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.W))
        {
            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun2();
        }
       

       // Debug.Log(v3_Ranger);

    }
}
