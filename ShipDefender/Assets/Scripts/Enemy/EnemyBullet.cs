using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {



    public GameObject go_EnemyBullet;

    public GameObject go_Explosion;
    public Rigidbody2D rb_EnemyBullet;

    public Transform explosionTransform;

    public Transform enemyBulletTransform;
    private Vector3 v3_enemyBullet;

    public Transform enemyBulletContainerTransform;

    public Transform ufo1GunTransform;
    public Transform ufo2GunTransform;
    public Transform ufo3GunTransform;

    public Transform ufo1Transform;
    public Transform ufo2Transform;
    public Transform ufo3Transform;


    private float f_speed = 50f;
    private float f_random;

    private float f_counter = 0.5f;

    void Start () {

        

        if (this.gameObject.name == "laserUFO1")
        {
            ufo1Transform = GameObject.Find("ufo1(Clone)").GetComponent<Transform>();
        }
        if (this.gameObject.name == "laserUFO2")
        {
            ufo2Transform = GameObject.Find("ufo2(Clone)").GetComponent<Transform>();
        }
        if (this.gameObject.name == "laserUFO3")
        {
            ufo3Transform = GameObject.Find("ufo3(Clone)").GetComponent<Transform>();
        }


    }


    private void OnDisable()
    {
        if (this.gameObject.name == "laserUFO1")
        {
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
        if (this.gameObject.name == "laserUFO2")
        {
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
        if (this.gameObject.name == "laserUFO3")
        {
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RANGER")

        {
            
            Instantiate(go_Explosion, v3_enemyBullet, new Quaternion());
            explosionTransform.position = enemyBulletTransform.position;
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }
        if (collision.gameObject.tag == "SCOUT")

        {
            
            Instantiate(go_Explosion, v3_enemyBullet, new Quaternion());
            explosionTransform.position = enemyBulletTransform.position;
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }

        if (collision.gameObject.tag == "CORSAIR")

        {

            Instantiate(go_Explosion, v3_enemyBullet, new Quaternion());
            explosionTransform.position = enemyBulletTransform.position;
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }
        if (collision.gameObject.name == "MainStationSprite")

        {

            Instantiate(go_Explosion, v3_enemyBullet, new Quaternion());
            explosionTransform.position = enemyBulletTransform.position;
            go_EnemyBullet.SetActive(false);
            enemyBulletTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
            FindObjectOfType<AudioManager>().Play("shipExplosion");

        }
    }



    private void FixedUpdate()
    {

        rb_EnemyBullet.AddForce(enemyBulletTransform.up * f_speed);

    }


    void Update () {


        v3_enemyBullet.x = enemyBulletTransform.position.x;
        v3_enemyBullet.y = enemyBulletTransform.position.y;
        v3_enemyBullet.z = enemyBulletTransform.position.z;


        if (enemyBulletTransform.position.x > 100 || enemyBulletTransform.position.x < -100 || enemyBulletTransform.position.y > 100 || enemyBulletTransform.position.y < -100)
        {

            if (this.gameObject.name == "laserUFO1")
            {
                go_EnemyBullet.SetActive(false);

            }
            if (this.gameObject.name == "laserUFO2")
            {
                go_EnemyBullet.SetActive(false);

            }
            if (this.gameObject.name == "laserUFO3")
            {
                go_EnemyBullet.SetActive(false);
            }



        }

    }
}
