using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{

    public GameObject go_ufo;
    public GameObject go_shipExplosionInst;

    public GameObject go_gunFireUFO1;
    public GameObject go_gunFireUFO2;
    public GameObject go_gunFireUFO3;
    public GameObject go_engineFireUFO1;
    public GameObject go_engineFireUFO2;
    public GameObject go_engineFireUFO3;


    public Transform ufoTransform;
    public Transform gunTransformUFO1;
    public Transform gunTransformUFO2;
    public Transform gunTransformUFO3;

    public GameObject target1MainStation;
    public GameObject target2Ranger1;
    public GameObject target3Ranger2;
    public GameObject target4Ranger3;
    public GameObject target5Scout1;
    public GameObject target6Scout2;
    public GameObject target7Scout3;
    public GameObject target8Scout4;

    public Transform target1MainStationTransform;
    public Transform target2Ranger1Transform;
    public Transform target3Ranger2Transform;
    public Transform target4Ranger3Transform;
    public Transform target5Scout1Transform;
    public Transform target6Scout2Transform;
    public Transform target7Scout3Transform;
    public Transform target8Scout4Transform;
    public Transform target9Corsair1Transform;
    public Transform target10Corsair2Transform;

    public GameObject laserRef;

    public List<GameObject> go_weaponListUFO1;
    private GameObject UFO1Gun;

    public List<GameObject> go_weaponListUFO2;
    private GameObject UFO2Gun;

    public List<GameObject> go_weaponListUFO3;
    private GameObject UFO3Gun;


    public bool b_IsFollowMainStation = true;

    public bool b_IsFollowingScout1 = false;
    public bool b_IsFollowingScout2 = false;
    public bool b_IsFollowingScout3 = false;
    public bool b_IsFollowingScout4 = false;

    public bool b_IsFollowingRanger1 = false;
    public bool b_IsFollowingRanger2 = false;
    public bool b_IsFollowingRanger3 = false;

    public bool b_IsFollowingCorsair1 = false;
    public bool b_IsFollowingCorsair2 = false;


    public bool b_UFO1IsAttacking = false;
    public bool b_UFO2IsAttacking = false;
    public bool b_UFO3IsAttacking = false;

    private float f_chaseRange = 200f;
          
    public GameObject go_EnergyInst;
    

    public Vector3 v3_UFO;

    public Transform SP_UFOTransform;

    float f_counter = 30;

    float f_rotationSpeed = 2f;
    float f_speed = 3f;

    void Start()
    {
        
        if (this.gameObject.name == "ufo1(Clone)")
        {
            go_ufo = this.gameObject;
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;

            target1MainStation = GameObject.Find("MainStation");
            target1MainStationTransform = target1MainStation.GetComponent<Transform>();

            target2Ranger1Transform = target2Ranger1.GetComponent<Transform>();
            target3Ranger2Transform = target3Ranger2.GetComponent<Transform>();
            target4Ranger3Transform = target4Ranger3.GetComponent<Transform>();

            target5Scout1Transform = target5Scout1.GetComponent<Transform>();
            target6Scout2Transform = target6Scout2.GetComponent<Transform>();
            target7Scout3Transform = target7Scout3.GetComponent<Transform>();
            target8Scout4Transform = target8Scout4.GetComponent<Transform>();

            go_gunFireUFO1.SetActive(false);

        }

        if (this.gameObject.name == "ufo2(Clone)")
        {
            go_ufo = this.gameObject;
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;


            target1MainStation = GameObject.Find("MainStation");
            target1MainStationTransform = target1MainStation.GetComponent<Transform>();

            target2Ranger1Transform = target2Ranger1.GetComponent<Transform>();
            target3Ranger2Transform = target3Ranger2.GetComponent<Transform>();
            target4Ranger3Transform = target4Ranger3.GetComponent<Transform>();

            target5Scout1Transform = target5Scout1.GetComponent<Transform>();
            target6Scout2Transform = target6Scout2.GetComponent<Transform>();
            target7Scout3Transform = target7Scout3.GetComponent<Transform>();
            target8Scout4Transform = target8Scout4.GetComponent<Transform>();

            go_gunFireUFO2.SetActive(false);
        }

        if (this.gameObject.name == "ufo3(Clone)")
        {
            go_ufo = this.gameObject;
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;


            target1MainStation = GameObject.Find("MainStation");
            target1MainStationTransform = target1MainStation.GetComponent<Transform>();

            target2Ranger1Transform = target2Ranger1.GetComponent<Transform>();
            target3Ranger2Transform = target3Ranger2.GetComponent<Transform>();
            target4Ranger3Transform = target4Ranger3.GetComponent<Transform>();

            target5Scout1Transform = target5Scout1.GetComponent<Transform>();
            target6Scout2Transform = target6Scout2.GetComponent<Transform>();
            target7Scout3Transform = target7Scout3.GetComponent<Transform>();
            target8Scout4Transform = target8Scout4.GetComponent<Transform>();

            go_gunFireUFO3.SetActive(false);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.name == "missleR1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR3" && this.gameObject.tag == "UFO"))

        {

            if (col.gameObject.name == "missleR1")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
                FindObjectOfType<AudioManager>().Play("explosion");
            }
            if (col.gameObject.name == "missleR2")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
                Debug.Log("MISSLE HITS UFO2");
                UFO1Destroyed();
                FindObjectOfType<AudioManager>().Play("explosion");
            }
            if (col.gameObject.name == "missleR3")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
                Debug.Log("MISSLE HITS UFO2");
                UFO1Destroyed();
                FindObjectOfType<AudioManager>().Play("explosion");
            }
        }
        if ((col.gameObject.name == "missleSeekerC1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleSeekerC2" && this.gameObject.tag == "UFO"))

        {

            if (col.gameObject.name == "missleSeekerC1")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
                FindObjectOfType<AudioManager>().Play("explosion");
            }
            if (col.gameObject.name == "missleSeekerC2")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
                Debug.Log("MISSLE HITS UFO2");
                UFO1Destroyed();
                FindObjectOfType<AudioManager>().Play("explosion");
            }

        }
        if ((col.gameObject.name == "bulletSC1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC3" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC4" && this.gameObject.tag == "UFO"))

        {

            f_counter = f_counter - 0.5f;

            // Debug.Log("BULLET HITS UFO1");

            if (f_counter <= 0)
            {
                if (col.gameObject.name == "bulletSC1")
                {
                    //go_ScoutInst.GetComponent<Scout>().b_IsAimed_Scout1 = false;
                    
                    f_counter = 30;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC2")
                {
                    //go_ScoutInst.GetComponent<Scout>().b_IsAimed_Scout1 = false;
                    
                    f_counter = 30;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC3")
                {
                    //go_ScoutInst.GetComponent<Scout>().b_IsAimed_Scout1 = false;

                    f_counter = 30;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC4")
                {
                    //go_ScoutInst.GetComponent<Scout>().b_IsAimed_Scout1 = false;

                    f_counter = 30;
                    UFO1Destroyed();
                }
            }

        }
    }

    //Kill UFO
    public void UFO1Destroyed()
    {

        Instantiate(go_shipExplosionInst, ufoTransform.position, new Quaternion());
        Instantiate(go_EnergyInst, ufoTransform.position, new Quaternion());
        FindObjectOfType<AudioManager>().Play("shipExplosion");
        //ufoTransform.position = SP_UFOTransform.position;
        //go_ufo.SetActive(false);
        Destroy(this.gameObject);
    }

    void FixedUpdate()
    {

        // ---> UFO Behavior
        //Get distance to the target
        float distanceToTarget1 = Vector3.Distance(transform.position, target1MainStationTransform.position);
        float distanceToTarget2 = Vector3.Distance(transform.position, target2Ranger1Transform.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, target3Ranger2Transform.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, target4Ranger3Transform.position);

        float distanceToTarget5 = Vector3.Distance(transform.position, target5Scout1Transform.position);
        float distanceToTarget6 = Vector3.Distance(transform.position, target6Scout2Transform.position);
        float distanceToTarget7 = Vector3.Distance(transform.position, target7Scout3Transform.position);
        float distanceToTarget8 = Vector3.Distance(transform.position, target8Scout4Transform.position);

        float distanceToTarget9 = Vector3.Distance(transform.position, target9Corsair1Transform.position);
        float distanceToTarget10 = Vector3.Distance(transform.position, target10Corsair2Transform.position);



        if (this.gameObject.name == "ufo1(Clone)")
        {
            //Following to MainStation
            if (Vector2.Distance(transform.position, target1MainStationTransform.position) > 15 && b_IsFollowMainStation == true && b_IsFollowingRanger1 == false && b_IsFollowingRanger2 == false && b_IsFollowingRanger3 == false && b_IsFollowingScout1 == false && b_IsFollowingScout2 == false && b_IsFollowingScout3 == false && b_IsFollowingScout4 == false)
            {

                Vector3 targetDir = target1MainStationTransform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger1
            if (b_IsFollowingRanger1 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target2Ranger1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger2
            if (b_IsFollowingRanger2 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target3Ranger2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger3
            if (b_IsFollowingRanger3 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target4Ranger3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout1
            if (b_IsFollowingScout1 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target5Scout1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout2
            if (b_IsFollowingScout2 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target6Scout2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout3
            if (b_IsFollowingScout3 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target7Scout3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout4
            if (b_IsFollowingScout4 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target8Scout4Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair1
            if (b_IsFollowingCorsair1 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target9Corsair1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair2
            if (b_IsFollowingCorsair2 == true && b_UFO1IsAttacking == false)
            {
                Vector3 targetDir = target10Corsair2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }

        }

        if (this.gameObject.name == "ufo2(Clone)")
        {
            //Following to MainStation
            if (Vector2.Distance(transform.position, target1MainStationTransform.position) > 15 && b_IsFollowMainStation == true && b_IsFollowingRanger1 == false && b_IsFollowingRanger2 == false && b_IsFollowingRanger3 == false && b_IsFollowingScout1 == false && b_IsFollowingScout2 == false && b_IsFollowingScout3 == false && b_IsFollowingScout4 == false)
            {

                Vector3 targetDir = target1MainStationTransform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger1
            if (b_IsFollowingRanger1 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target2Ranger1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger2
            if (b_IsFollowingRanger2 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target3Ranger2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger3
            if (b_IsFollowingRanger3 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target4Ranger3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout1
            if (b_IsFollowingScout1 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target5Scout1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout2
            if (b_IsFollowingScout2 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target6Scout2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout3
            if (b_IsFollowingScout3 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target7Scout3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout4
            if (b_IsFollowingScout4 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target8Scout4Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair1
            if (b_IsFollowingCorsair1 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target9Corsair1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair2
            if (b_IsFollowingCorsair2 == true && b_UFO2IsAttacking == false)
            {
                Vector3 targetDir = target10Corsair2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
        }

        if (this.gameObject.name == "ufo3(Clone)")
        {
            //Following to MainStation
            if (Vector2.Distance(transform.position, target1MainStationTransform.position) > 15 && b_IsFollowMainStation == true && b_IsFollowingRanger1 == false && b_IsFollowingRanger2 == false && b_IsFollowingRanger3 == false && b_IsFollowingScout1 == false && b_IsFollowingScout2 == false && b_IsFollowingScout3 == false && b_IsFollowingScout4 == false)
            {

                Vector3 targetDir = target1MainStationTransform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger1
            if (b_IsFollowingRanger1 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target2Ranger1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger2
            if (b_IsFollowingRanger2 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target3Ranger2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following ranger3
            if (b_IsFollowingRanger3 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target4Ranger3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout1
            if (b_IsFollowingScout1 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target5Scout1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout2
            if (b_IsFollowingScout2 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target6Scout2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout3
            if (b_IsFollowingScout3 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target7Scout3Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Scout4
            if (b_IsFollowingScout4 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target8Scout4Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair1
            if (b_IsFollowingCorsair1 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target9Corsair1Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
            //Following Corsair2
            if (b_IsFollowingCorsair2 == true && b_UFO3IsAttacking == false)
            {
                Vector3 targetDir = target10Corsair2Transform.position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

                transform.Translate(Vector3.up * Time.deltaTime * f_speed);
            }
        }

    }

}