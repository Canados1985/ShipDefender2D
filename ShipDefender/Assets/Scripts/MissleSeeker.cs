using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSeeker : MonoBehaviour {

    public static MissleSeeker cl_missleSeeker;


    public GameObject go_missleSeeker;
    public Rigidbody2D rb_missleSeeker;

    public Transform missleSeekerTransform;
    private Vector3 v3_missleSeeker;

    public GameObject go_ExplosionInst; // For Spawning Explosion
    public GameObject go_EnergyInst;

    public Transform explosionTransform;
    public Transform energyTransform;

    private float f_timer = 10f;
    private float f_speed = 5;
    private float f_rotationSpeed = 5f;


    public GameObject go_target1UFO1;
    public GameObject go_target2UFO2;
    public GameObject go_target3UFO3;
    public GameObject go_target4asteriod1;
    public GameObject go_target5asteriod2;

    public Transform target1UFO1Transform;
    public Transform target2UFO2Transform;
    public Transform target3UFO3Transform;
    public Transform target4asteriod1Transform;
    public Transform target5asteriod2Transform;


    public bool b_pickTarger1UFO1 = false;
    public bool b_pickTarger2UFO2 = false;
    public bool b_pickTarger3UFO3 = false;
    public bool b_pickTarger4Asteroid1 = false;
    public bool b_pickTarger5Asteroid2 = false;


    private bool b_target1 = false;
    private bool b_target2 = false;
    private bool b_target3 = false;

    public Transform targetTransform;

    float f_random;

    private void Awake()
    {

        f_random = Random.Range(0f, 4f);
    }

    void Start() {

        rb_missleSeeker = GetComponent<Rigidbody2D>();

}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "UFO")

        {
            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());
            Instantiate(go_EnergyInst, collision.transform.position, new Quaternion());

            go_missleSeeker.SetActive(false);
            missleSeekerTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
            b_pickTarger1UFO1 = false;
            b_pickTarger2UFO2 = false;
            b_pickTarger3UFO3 = false;

        }
        if (collision.gameObject.tag == "ASTEROID")

        {

            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());


            go_missleSeeker.SetActive(false);
            missleSeekerTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
            b_pickTarger4Asteroid1 = false;

        }
        if (collision.gameObject.tag == "ASTEROID2")

        {

            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());


            go_missleSeeker.SetActive(false);
            missleSeekerTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
            b_pickTarger5Asteroid2 = false;

        }
    }

    private void FixedUpdate()
    {

        float distanceToTarget1 = Vector3.Distance(transform.position, target1UFO1Transform.position);
        float distanceToTarget2 = Vector3.Distance(transform.position, target2UFO2Transform.position);
        float distanceToTarget3 = Vector3.Distance(transform.position, target3UFO3Transform.position);
        float distanceToTarget4 = Vector3.Distance(transform.position, target4asteriod1Transform.position);
        float distanceToTarget5 = Vector3.Distance(transform.position, target5asteriod2Transform.position);


        if (b_pickTarger1UFO1 == true)
        {

            Vector3 targetDir = target1UFO1Transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        if (b_pickTarger2UFO2 == true)
        {

            Vector3 targetDir = target2UFO2Transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        if (b_pickTarger3UFO3 == true)
        {

            Vector3 targetDir = target3UFO3Transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        if (b_pickTarger4Asteroid1 == true)
        {

            Vector3 targetDir = target4asteriod1Transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        if (b_pickTarger5Asteroid2 == true)
        {

            Vector3 targetDir = target5asteriod2Transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }
        else { transform.Translate(Vector3.up * Time.deltaTime * f_speed); }
        

    
    }


    void Update () {


        v3_missleSeeker.x = missleSeekerTransform.position.x;
        v3_missleSeeker.y = missleSeekerTransform.position.y;
        v3_missleSeeker.z = missleSeekerTransform.position.z;


        if (missleSeekerTransform.position.x > 50 || missleSeekerTransform.position.x < -50 || missleSeekerTransform.position.y > 50 || missleSeekerTransform.position.y < -50)
        {

            if (this.gameObject.name == "missleSeekerC1")
            {
                go_missleSeeker.SetActive(false);

            }
            if (this.gameObject.name == "missleSeekerC2")
            {
                go_missleSeeker.SetActive(false);

            }


        }



    }
}
