using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour {

   	public GameObject go_Missle;
    public GameObject go_Explosion;
    public GameObject go_flame;

    public Rigidbody2D rb_Missle;

    public Transform explosionTransform;

    public Transform missleTransform;
    private Vector3 v3_missle;



    private float f_speed = 50f;
    private float f_random;

    private float f_counter = 0.5f;

    public float f_flameCounter = 0.5f;

	void Start () {

        go_flame.SetActive(false);
        f_flameCounter = 0.5f;
    }



    private void OnDisable()
    {
        if (this.gameObject.name == "missleR1")
        {

            go_Missle.SetActive(false);
            f_flameCounter = 0.5f;
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
        if (this.gameObject.name == "missleR2")
        {
            go_Missle.SetActive(false);
            f_flameCounter = 0.5f;
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
        if (this.gameObject.name == "missleR3")
        {
            go_Missle.SetActive(false);
            f_flameCounter = 0.5f;
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UFO")

        {
            Debug.Log("MISSLE HITS UFO");
            Instantiate(go_Explosion, v3_missle, new Quaternion());
            explosionTransform.position = missleTransform.position;
            go_Missle.SetActive(false);
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }

        if (collision.gameObject.tag == "ASTEROID")

        {
            Debug.Log("MISSLE HITS ASTEROID");
            explosionTransform.position = missleTransform.position;
            Instantiate(go_Explosion, v3_missle, new Quaternion());
            go_Missle.SetActive(false);
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }


        if (collision.gameObject.tag == "ASTEROID2")

        {
            Debug.Log("MISSLE HITS ASTEROID2");
            explosionTransform.position = missleTransform.position;
            Instantiate(go_Explosion, v3_missle, new Quaternion());
            go_Missle.SetActive(false);
            missleTransform.position = ObjPoolManager.cl_ObjPoolManager.transform.position;

        }

    }


    private void FixedUpdate()
    {

        if (go_Missle.activeSelf == true) { f_flameCounter -= Time.deltaTime; }
        if (f_flameCounter <= 0) { go_flame.SetActive(true); f_flameCounter = 0.5f; }

        rb_Missle.AddForce(missleTransform.up * f_speed);

    }



    void  Update () {

        v3_missle.x = missleTransform.position.x;
        v3_missle.y = missleTransform.position.y;
        v3_missle.z = missleTransform.position.z;


        if (missleTransform.position.x > 100 || missleTransform.position.x < -100 || missleTransform.position.y > 100 || missleTransform.position.y < -100)
        {

            if (this.gameObject.name == "missleR1")
            {
                go_Missle.SetActive(false);
               
            }
            if (this.gameObject.name == "missleR2")
            {
                go_Missle.SetActive(false);
                
            }
            if (this.gameObject.name == "missleR3")
            {
                go_Missle.SetActive(false);
            }



        }
	}


}
