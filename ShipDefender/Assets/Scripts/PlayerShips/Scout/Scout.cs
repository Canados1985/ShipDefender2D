using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : MonoBehaviour {

    public GameObject go_Scout;
    public Rigidbody2D rb_Scout;

    public Transform ScoutContainerTransform; 

    public GameObject go_shipExplosionInst;

    public Transform scoutTransform;
    public Transform mainStationTransformInst;

    public Transform scoutGun1Transform;
    public Transform scoutGun2Transform;

    public GameObject target1MainStation;
    public GameObject target2PointPatrol1;
    public GameObject target3PointPatrol2;
    public GameObject target4UFO1;
    public GameObject target5UFO2;
    public GameObject target6UFO3;
    public GameObject target7Asteroid1;
    public GameObject target8Asteroid2;


    public Transform pointPatrol1TransformTarget; // Ranger point1 position
    public Transform pointPatrol2TransformTarget; // Ranger point2 position
    public Transform mainStationTransformTarget; // Main station position
    public Transform ufo1TransformTarget; // UFO1 position
    public Transform ufo2TransformTarget; // UFO2 position
    public Transform ufo3TransformTarget; // UFO3 position
    public Transform asteroid1TransformTarget; // Asteroid1 position
    public Transform asteroid2TransformTarget; // Asteroid2 position

    private Vector3 v3_Scout;

    public GameObject go_flame1;
    public GameObject go_flame2;

    public GameObject go_gunFire1;
    public GameObject go_gunFire2;

    private float f_chaseRange = 3f;

    private float f_counterS1 = 5f;
    private float f_counterS2 = 5f;
    private float f_counterS3 = 5f;
    private float f_counterS4 = 5f;


    public bool b_GunSound = false;

    public bool b_IsAimed_Scout1 = false;
    public bool b_backOnBase_Scout1 = false;

    public bool b_IsAimed_Scout2 = false;
    public bool b_backOnBase_Scout2 = false;

    public bool b_IsAimed_Scout3 = false;
    public bool b_backOnBase_Scout3 = false;

    public bool b_IsAimed_Scout4 = false;
    public bool b_backOnBase_Scout4 = false;


    public bool b_movingToPatrolPoint1 = false;
    public bool b_movingToPatrolPoint2 = true;
    public bool b_movingBackToBase = false;
    public bool b_chasingUFO = false;
    public bool b_chasingAsteroid = false;


    //public float f_counter = 0f;

    private float f_rotationSpeed = 2.5f;
    private float f_speed = 3.5f;

    // public bool b_IsShoting = false;


    void Start()
    {


        if (this.gameObject.name == "scout1")
        {
            go_Scout = GameObject.Find("scout1");
            rb_Scout = go_Scout.GetComponent<Rigidbody2D>();
            scoutTransform = go_Scout.GetComponent<Transform>();
            ScoutContainerTransform = ScoutContainer.cl_ScoutContainer.GetComponent<Transform>();
            go_gunFire1.SetActive(false);
            go_gunFire2.SetActive(false);

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

        if (this.gameObject.name == "scout2")
        {
            go_Scout = GameObject.Find("scout2");
            rb_Scout = go_Scout.GetComponent<Rigidbody2D>();
            scoutTransform = go_Scout.GetComponent<Transform>();
            ScoutContainerTransform = ScoutContainer.cl_ScoutContainer.GetComponent<Transform>();
            go_gunFire1.SetActive(false);
            go_gunFire2.SetActive(false);

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

        if (this.gameObject.name == "scout3")
        {
            go_Scout = GameObject.Find("scout3");
            rb_Scout = go_Scout.GetComponent<Rigidbody2D>();
            scoutTransform = go_Scout.GetComponent<Transform>();
            ScoutContainerTransform = ScoutContainer.cl_ScoutContainer.GetComponent<Transform>();
            go_gunFire1.SetActive(false);
            go_gunFire2.SetActive(false);

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

        if (this.gameObject.name == "scout4")
        {
            go_Scout = GameObject.Find("scout4");
            rb_Scout = go_Scout.GetComponent<Rigidbody2D>();
            scoutTransform = go_Scout.GetComponent<Transform>();
            ScoutContainerTransform = ScoutContainer.cl_ScoutContainer.GetComponent<Transform>();
            go_gunFire1.SetActive(false);
            go_gunFire2.SetActive(false);

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

    void DestroyScout()
    {
        go_Scout.SetActive(false);
        scoutTransform.position = ScoutContainerTransform.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ENEMYBULLET")
        {
            FindObjectOfType<AudioManager>().Play("shipExplosion");
            DestroyScout();
        }

    }


    public void GunSound()
    {
        if (b_GunSound == false)
        {
            FindObjectOfType<AudioManager>().Play("scoutGun");
            b_GunSound = true;
        }
        
    }



    void FixedUpdate()
    {

        if (b_IsAimed_Scout1 == true || b_IsAimed_Scout2 == true || b_IsAimed_Scout3 == true || b_IsAimed_Scout4 == true)
        {
            f_counterS1 -= Time.deltaTime;
            f_counterS2 -= Time.deltaTime;
            f_counterS3 -= Time.deltaTime;
            f_counterS4 -= Time.deltaTime;

            if (f_counterS1 < 5 || f_counterS2 < 5 || f_counterS3 < 5 || f_counterS4 < 5)
            {
                go_gunFire1.SetActive(false);
                go_gunFire2.SetActive(false);
            }

            if (f_counterS1 <= 0 && b_IsAimed_Scout1 == true) { b_IsAimed_Scout1 = false; f_counterS1 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
            if (f_counterS2 <= 0 && b_IsAimed_Scout2 == true) { b_IsAimed_Scout2 = false; f_counterS2 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
            if (f_counterS3 <= 0 && b_IsAimed_Scout3 == true) { b_IsAimed_Scout3 = false; f_counterS3 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
            if (f_counterS4 <= 0 && b_IsAimed_Scout4 == true) { b_IsAimed_Scout4 = false; f_counterS4 = 3; go_flame1.SetActive(true); go_flame2.SetActive(true); }
        }



        float distanceToTarget2 = Vector3.Distance(transform.position, pointPatrol1TransformTarget.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, pointPatrol2TransformTarget.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, ufo1TransformTarget.position);
        float distanceToTarget5 = Vector3.Distance(transform.position, ufo2TransformTarget.position);
        float distanceToTarget6 = Vector3.Distance(transform.position, ufo3TransformTarget.position);


        // SCouts Behavior --->
        if (this.gameObject.name == "scout1")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Scout1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Scout1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Scout1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Scout1 == false && b_chasingAsteroid == false)
            {

                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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
            if (b_chasingUFO == false && b_IsAimed_Scout1 == false && b_chasingAsteroid == true)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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

        if (this.gameObject.name == "scout2")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Scout2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Scout2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Scout2 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Scout2 == false && b_chasingAsteroid == false)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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
            if (b_chasingUFO == false && b_IsAimed_Scout2 == false && b_chasingAsteroid == true)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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

        if (this.gameObject.name == "scout3")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Scout3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Scout3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Scout3 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Scout3 == false && b_chasingAsteroid == false)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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
            if (b_chasingUFO == false && b_IsAimed_Scout3 == false && b_chasingAsteroid == true)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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

        if (this.gameObject.name == "scout4")
        {
            //Moving to Patrol Point 1
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Scout4 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);


            }
            if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) { b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
            //Moving to Patrol Point 2
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) > 0.5f && b_movingToPatrolPoint2 == true && b_IsAimed_Scout4 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {


                Vector3 targetDir = pointPatrol2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, pointPatrol2TransformTarget.position) <= 0.5f && b_movingToPatrolPoint2 == true) { b_movingBackToBase = true; b_movingToPatrolPoint2 = false; }
            //Moving to Base
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) > 0.5f && b_movingBackToBase == true && b_IsAimed_Scout4 == false && b_chasingUFO == false && b_chasingAsteroid == false)
            {

                Vector3 targetDir = mainStationTransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (Vector2.Distance(transform.position, mainStationTransformTarget.position) <= 0.5f && b_movingBackToBase == true) { b_movingBackToBase = false; b_movingToPatrolPoint1 = true; }
            //Chasing UFO
            if (b_chasingUFO == true && b_IsAimed_Scout4 == false && b_chasingAsteroid == false)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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
            if (b_chasingUFO == false && b_IsAimed_Scout4 == false && b_chasingAsteroid == true)
            {
                ScoutSensor tempSensor = gameObject.transform.GetComponentInChildren<ScoutSensor>();
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


    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            ObjPoolManager.cl_ObjPoolManager.FireS1G1();
            ObjPoolManager.cl_ObjPoolManager.FireS1G2();

            ObjPoolManager.cl_ObjPoolManager.FireS2G1();
            ObjPoolManager.cl_ObjPoolManager.FireS2G2();

            ObjPoolManager.cl_ObjPoolManager.FireS3G1();
            ObjPoolManager.cl_ObjPoolManager.FireS3G2();

            ObjPoolManager.cl_ObjPoolManager.FireS4G1();
            ObjPoolManager.cl_ObjPoolManager.FireS4G2();
        }
        */
    }

}
