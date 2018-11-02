using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : MonoBehaviour {

    public static Ranger cl_Ranger;

    private Vector3 v3_Ranger;

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

    private float f_chaseRange = 3f;

    public GameObject go_Ranger;
    public Rigidbody2D rb_Ranger;

    public Transform rangerTransform;
    public Transform rangerGun1Transform;
    public Transform rangerGun2Transform;

    public GameObject missleRef;

    private float f_counter = 2f;

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

    public bool b_movingToPatrolPoint1 = true;
    public bool b_movingToPatrolPoint2 = false;
    public bool b_movingBackToBase = false;
    public bool b_chasingUFO = false;
    public bool b_chasingAsteroid = false;


    public bool b_Gun1 = false;
    public bool b_Gun2 = false;


    public List<GameObject> go_missleListR1Gun1;
    private GameObject missleContainerR1Gun1;
    public List<GameObject> go_missleListR1Gun2;
    private GameObject missleContainerR1Gun2;

    public List<GameObject> go_missleListR2Gun1;
    private GameObject missleContainerR2Gun1;
    public List<GameObject> go_missleListR2Gun2;
    private GameObject missleContainerR2Gun2;

    public List<GameObject> go_missleListR3Gun1;
    private GameObject missleContainerR3Gun1;
    public List<GameObject> go_missleListR3Gun2;
    private GameObject missleContainerR3Gun2;

    void Start() {
      
           
        
        //Set up load for Ranger 1
        if (this.gameObject.name == "ranger1")
        {
            cl_Ranger = this;
            go_Ranger = GameObject.Find("ranger1");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();

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

            rangerGun1Transform = GameObject.Find("ranger1/gun1").transform;
            rangerGun2Transform = GameObject.Find("ranger1/gun2").transform;

                       
            //Missle list Ranger 1 GUN1
            go_missleListR1Gun1 = new List<GameObject>();
            missleContainerR1Gun1 = GameObject.Find("ranger1/gun1");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR1Gun1.Add(temp);
                go_missleListR1Gun1[i].transform.parent = missleContainerR1Gun1.transform;
                go_missleListR1Gun1[i].transform.position = missleContainerR1Gun1.transform.position;
                go_missleListR1Gun1[i].transform.rotation = missleContainerR1Gun1.transform.rotation;
                go_missleListR1Gun1[i].name = "missleR1";
            }
            //Missle list Ranger 1 GUN2
            go_missleListR1Gun2 = new List<GameObject>();
            missleContainerR1Gun2 = GameObject.Find("ranger1/gun2");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR1Gun2.Add(temp);
                go_missleListR1Gun2[i].transform.parent = missleContainerR1Gun2.transform;
                go_missleListR1Gun2[i].transform.position = missleContainerR1Gun2.transform.position;
                go_missleListR1Gun2[i].name = "missleR1";
            }

        }


        //Set up load for Ranger
        if (this.gameObject.name == "ranger2")
        {
            cl_Ranger = this;
            go_Ranger = GameObject.Find("ranger2");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();

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

            rangerGun1Transform = GameObject.Find("ranger2/gun1").transform;
            rangerGun2Transform = GameObject.Find("ranger2/gun2").transform;

            //Missle list Ranger 2 GUN1
            go_missleListR2Gun1 = new List<GameObject>();
            missleContainerR2Gun1 = GameObject.Find("ranger2/gun1");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR2Gun1.Add(temp);
                go_missleListR2Gun1[i].transform.parent = missleContainerR2Gun1.transform;
                go_missleListR2Gun1[i].transform.position = missleContainerR2Gun1.transform.position;
                go_missleListR2Gun1[i].name = "missleR2";
            }
            //Missle list Ranger 2 GUN2
            go_missleListR2Gun2 = new List<GameObject>();
            missleContainerR2Gun2 = GameObject.Find("ranger2/gun2");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR2Gun2.Add(temp);
                go_missleListR2Gun2[i].transform.parent = missleContainerR2Gun2.transform;
                go_missleListR2Gun2[i].transform.position = missleContainerR2Gun2.transform.position;
                go_missleListR2Gun2[i].name = "missleR2";
            }
        }


        //Set up load for Ranger 3
        if (this.gameObject.name == "ranger3")
        {
            cl_Ranger = this;
            go_Ranger = GameObject.Find("ranger3");
            rb_Ranger = go_Ranger.GetComponent<Rigidbody2D>();
            rangerTransform = go_Ranger.GetComponent<Transform>();

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

            rangerGun1Transform = GameObject.Find("ranger3/gun1").transform;
            rangerGun2Transform = GameObject.Find("ranger3/gun2").transform;

            //Missle list Ranger 3 GUN1
            go_missleListR3Gun1 = new List<GameObject>();
            missleContainerR3Gun1 = GameObject.Find("ranger3/gun1");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR3Gun1.Add(temp);
                go_missleListR3Gun1[i].transform.parent = missleContainerR3Gun1.transform;
                go_missleListR3Gun1[i].transform.position = missleContainerR3Gun1.transform.position;
                go_missleListR3Gun1[i].name = "missleR3";
            }
            go_missleListR3Gun2 = new List<GameObject>();
            missleContainerR3Gun2 = GameObject.Find("ranger3/gun2");
            for (int i = 0; i < 5; i++)
            {
                GameObject temp = Instantiate(missleRef);
                temp.SetActive(false);
                go_missleListR3Gun2.Add(temp);
                go_missleListR3Gun2[i].transform.parent = missleContainerR3Gun2.transform;
                go_missleListR3Gun2[i].transform.position = missleContainerR3Gun2.transform.position;
                go_missleListR3Gun2[i].name = "missleR3";
            }
        }


    }

      //Set Missle1 Active for Ranger1
    public GameObject Ranger1LaunchMissleGun1()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR1Gun1[i].activeSelf)
            {
                    go_missleListR1Gun1[i].transform.position = missleContainerR1Gun1.transform.position;
                    go_missleListR1Gun1[i].transform.rotation = missleContainerR1Gun1.transform.rotation;
                    go_missleListR1Gun1[i].SetActive(true);
                    return go_missleListR1Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR1Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }


    //Set Missle2 Active from Ranger1
    public GameObject Ranger1LaunchMissleGun2()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR1Gun2[i].activeSelf)
            {

                    go_missleListR1Gun2[i].transform.position = missleContainerR1Gun2.transform.position;
                    go_missleListR1Gun2[i].transform.rotation = missleContainerR1Gun2.transform.rotation;
                    go_missleListR1Gun2[i].SetActive(true);
                    return go_missleListR1Gun2[i];
            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR1Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }


    //Set Missle1 Active for Ranger2
    public GameObject Ranger2LaunchMissleGun1()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR2Gun1[i].activeSelf)
            {
                go_missleListR2Gun1[i].transform.position = missleContainerR2Gun1.transform.position;
                go_missleListR2Gun1[i].transform.rotation = missleContainerR2Gun1.transform.rotation;
                go_missleListR2Gun1[i].SetActive(true);
                return go_missleListR2Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR2Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle2 Active from Ranger2
    public GameObject Ranger2LaunchMissleGun2()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR2Gun2[i].activeSelf)
            {

                go_missleListR2Gun2[i].transform.position = missleContainerR2Gun2.transform.position;
                go_missleListR2Gun2[i].transform.rotation = missleContainerR2Gun2.transform.rotation;
                go_missleListR2Gun2[i].SetActive(true);
                return go_missleListR2Gun2[i];


            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR2Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set Missle1 Active for Ranger3
    public GameObject Ranger3LaunchMissleGun1()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR3Gun1[i].activeSelf)
            {
                go_missleListR3Gun1[i].transform.position = missleContainerR3Gun1.transform.position;
                go_missleListR3Gun1[i].transform.rotation = missleContainerR3Gun1.transform.rotation;
                go_missleListR3Gun1[i].SetActive(true);
                return go_missleListR3Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR3Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle2 Active from Ranger3
    public GameObject Ranger3LaunchMissleGun2()
    {
        for (int i = 0; i < 5; i++)
        {
            if (!go_missleListR3Gun2[i].activeSelf)
            {

                go_missleListR3Gun2[i].transform.position = missleContainerR3Gun2.transform.position;
                go_missleListR3Gun2[i].transform.rotation = missleContainerR3Gun2.transform.rotation;
                go_missleListR3Gun2[i].SetActive(true);
                return go_missleListR3Gun2[i];


            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR3Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    void FixedUpdate()
    {


        if (b_IsAimed_Ranger1 == true || b_IsAimed_Ranger2 == true || b_IsAimed_Ranger3 == true)
        {
            f_counter -= Time.deltaTime;
            if (f_counter <= 0 && b_IsAimed_Ranger1 == true) { b_IsAimed_Ranger1 = false; f_counter = 2; }
            if (f_counter <= 0 && b_IsAimed_Ranger2 == true) { b_IsAimed_Ranger2 = false; f_counter = 2; }
            if (f_counter <= 0 && b_IsAimed_Ranger3 == true) { b_IsAimed_Ranger3 = false; f_counter = 2; }
        }


        //Moving to PatrolPoint

        float distanceToTarget2 = Vector3.Distance(transform.position, pointPatrol1TransformTarget.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, pointPatrol2TransformTarget.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, ufo1TransformTarget.position);
        float distanceToTarget5 = Vector3.Distance(transform.position, ufo2TransformTarget.position);
        float distanceToTarget6 = Vector3.Distance(transform.position, ufo3TransformTarget.position);

        //Moving to Patrol Point 1
        if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) > 0.5f && b_movingToPatrolPoint1 == true && b_IsAimed_Ranger1 == false && b_chasingUFO == false && b_chasingAsteroid == false)
                {
                        
           
                    Vector3 targetDir = pointPatrol1TransformTarget.position - transform.position;
                    float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                    transform.Translate(Vector3.up * Time.deltaTime * f_speed);


                }
                if (Vector2.Distance(transform.position, pointPatrol1TransformTarget.position) <= 0.5f) {  b_movingToPatrolPoint1 = false; b_movingToPatrolPoint2 = true; }
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


        //Chasing UFO1
        if (b_chasingUFO == true && b_IsAimed_Ranger1 == false && b_chasingAsteroid == false)
        {

            if (RangerSensor.cl_RangerSensor.b_colIsUFO1 == true)
            {
                Vector3 targetDir = ufo1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (RangerSensor.cl_RangerSensor.b_colIsUFO2 == true)
            {
                Vector3 targetDir = ufo2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            if (RangerSensor.cl_RangerSensor.b_colIsUFO3 == true)
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

            if (RangerSensor.cl_RangerSensor.b_colIsAsteriod1 == true)
            {
                Vector3 targetDir = asteroid1TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }

            if (RangerSensor.cl_RangerSensor.b_colIsAsteroid2 == true)
            {
                Vector3 targetDir = asteroid2TransformTarget.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
        }


       }



    void Update()
    {

        Debug.Log(f_speed);

    }
}
