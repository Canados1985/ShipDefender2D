using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSeeker : MonoBehaviour {

    public static MissleSeeker cl_missleSeeker;

    GameObject target;
    Quaternion rotateToTarget;
    
    public GameObject go_missleSeeker;
    public Rigidbody2D rb_missleSeeker;

    public Transform missleSeekerTransform;
    private Vector3 v3_missleSeeker;

    public GameObject go_ExplosionInst; // For Spawning Explosion
    public GameObject go_EnergyInst;

    public Transform explosionTransform;
    public Transform energyTransform;

    //private float f_velocity = 300f;
    private float f_speed = 20;
    private float f_rotationSpeed = 1000f;


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

      
        if (f_random < 1f)
        {
            target = GameObject.Find("ufo1");
            targetTransform = target.GetComponent<Transform>();
        }
        if (f_random >= 1f && f_random <= 2f)
        {
            target = GameObject.Find("asteroid1");
            targetTransform = target.GetComponent<Transform>();
        }
        if (f_random > 2f)
        {
            
            target = GameObject.Find("asteroid2");
            targetTransform = target.GetComponent<Transform>();
            Debug.Log("RANDOM FLOAT " + f_random);
        }

        rb_missleSeeker = GetComponent<Rigidbody2D>();
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UFO")

        {
            Debug.Log("MISSLE HITS UFO");
            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());
            Instantiate(go_EnergyInst, collision.transform.position, new Quaternion());

            go_missleSeeker.SetActive(false);

            ufo.cl_ufo.UFO1Destroyed();

        }
        if (collision.gameObject.tag == "ASTEROID")

        {
            Debug.Log("MISSLE HITS ASTEROID");
            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());


            go_missleSeeker.SetActive(false);

            Asteroid_1.cl_Asteroid1.DestroyAsteroid();

        }
        if (collision.gameObject.tag == "ASTEROID2")

        {
            Debug.Log("MISSLE HITS ASTEROID2");
            explosionTransform.position = collision.transform.position;
            Instantiate(go_ExplosionInst, collision.transform.position, new Quaternion());


            go_missleSeeker.SetActive(false);

            Asteroid_2.cl_Asteroid2.DestroyAsteroid();

        }
    }
    

    private void FixedUpdate()
    {


        v3_missleSeeker = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(v3_missleSeeker.y, v3_missleSeeker.x) * Mathf.Rad2Deg;
        rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * f_rotationSpeed);

        rb_missleSeeker.velocity = transform.right * f_speed;
        

    }


    void Update () {

        Debug.Log(explosionTransform.position);



    }
}
