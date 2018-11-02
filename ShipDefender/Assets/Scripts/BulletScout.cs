using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScout : MonoBehaviour {

    public static BulletScout cl_BulletScout;

    public GameObject go_BulletScout;
    public GameObject go_Explosion;

    public Transform explosionTransform;
    public Transform bulletContainerTransform;

    public Rigidbody2D rb_BulletScout;


    public Transform bulletScoutTransform;
    private Vector3 v3_BulletScout;

    
    public Transform scoutGunTransform;

    public Transform scout1Transform;
    public Transform scout2Transform;
    public Transform scout3Transform;
    public Transform scout4Transform;

    public bool b_startsMoving = false;
    public float f_counter = 0;


    private float f_speed = 500f;

    void Start() {

        cl_BulletScout = this;

        bulletContainerTransform = GameObject.Find("BulletContainer").transform;

    }



    private void OnEnable()
    {
        Invoke("Disable", 1);

    }

    private void Disable()
    {
        go_BulletScout.SetActive(false);
        rb_BulletScout.velocity = Vector3.zero;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UFO")

        {
            Debug.Log("MISSLE HITS UFO");
            Instantiate(go_Explosion, v3_BulletScout, new Quaternion());
            explosionTransform.localScale = new Vector3(0.5f,0.5f,0.5f);
            explosionTransform.position = collision.transform.position;
            
            go_BulletScout.SetActive(false);
            bulletScoutTransform.position = bulletContainerTransform.position;

        }



        if (collision.gameObject.tag == "ASTEROID")

        {
            Debug.Log("MISSLE HITS ASTEROID");
            explosionTransform.position = bulletScoutTransform.position;
            Instantiate(go_Explosion, v3_BulletScout, new Quaternion());
            go_BulletScout.SetActive(false);
            bulletScoutTransform.position = bulletContainerTransform.position;


        }




        if (collision.gameObject.tag == "ASTEROID2")

        {
            Debug.Log("MISSLE HITS ASTEROID2");
            explosionTransform.position = bulletScoutTransform.position;
            Instantiate(go_Explosion, v3_BulletScout, new Quaternion());
            go_BulletScout.SetActive(false);
            bulletScoutTransform.position = bulletContainerTransform.position;


        }


    }



    private void FixedUpdate()
    {
        //rb_Missle.AddForce(new Vector3(8f,0,0));
        rb_BulletScout.AddForce(bulletScoutTransform.up * f_speed);
    }


    void Update()
    {


        v3_BulletScout.x = bulletScoutTransform.position.x;
        v3_BulletScout.y = bulletScoutTransform.position.y;
        v3_BulletScout.z = bulletScoutTransform.position.z;


               
    /*    if (Scout.cl_Scout.b_IsAimed_Scout1 == true && b_startsMoving == false)
        {
            scout1Transform = GameObject.Find("scout1").transform;
            
            bulletScoutTransform.rotation = scout1Transform.rotation;
            bulletScoutTransform.position = new Vector2(scout1Transform.position.x, scout1Transform.position.y);
            b_startsMoving = true;
            f_counter = 0.1f;
            
        }


        if (Scout.cl_Scout.b_IsAimed_Scout1 == true)
        {
            scout2Transform = GameObject.Find("scout2").transform;
            bulletScoutTransform.position = scout2Transform.position;
            bulletScoutTransform.rotation = scout2Transform.rotation;
        }

        if (Scout.cl_Scout.b_IsAimed_Scout1 == true)
        {
            scout3Transform = GameObject.Find("scout3").transform;
            bulletScoutTransform.position = scout3Transform.position;
            bulletScoutTransform.rotation = scout3Transform.rotation;

        }

        if (Scout.cl_Scout.b_IsAimed_Scout4 == true)
        {
            scout4Transform = GameObject.Find("scout4").transform;
            bulletScoutTransform.position = scout4Transform.position;
            bulletScoutTransform.rotation = scout4Transform.rotation;

        }
*/

        if (bulletScoutTransform.position.x > 50 || bulletScoutTransform.position.x < -50 || bulletScoutTransform.position.y > 50 || bulletScoutTransform.position.y < -50)
        {


             bulletScoutTransform.position = bulletScoutTransform.position;
             go_BulletScout.SetActive(false);
            
            //missleTransform.position = rangerTransform.position;
            //missleTransform.rotation = rangerTransform.rotation;



        }
    }



}
