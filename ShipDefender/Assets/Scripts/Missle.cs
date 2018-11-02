using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour {

    public static Missle cl_Missle;

	public GameObject go_Missle;
    public GameObject go_Explosion;
    public Rigidbody2D rb_Missle;

    public Transform explosionTransform;

    public Transform missleTransform;
    private Vector3 v3_missle;

    public Transform missleContainerTransform;

    public Transform rangerGun1Transform;
    public Transform rangerGun2Transform;

    public Transform ranger1Transform;
    public Transform ranger2Transform;
    public Transform ranger3Transform;


    private float f_speed = 50f;
    private float f_random;

    private float f_counter = 0.5f;

	void Start () {


        cl_Missle = this;

        missleContainerTransform = GameObject.Find("MissleContainer").transform;

        if (this.gameObject.name == "missleR1")
        {
            ranger1Transform = GameObject.Find("ranger1").GetComponent<Transform>();
        }
        if (this.gameObject.name == "missleR2")
        {
            ranger2Transform = GameObject.Find("ranger2").GetComponent<Transform>();
        }
        if (this.gameObject.name == "missleR3")
        {
            ranger3Transform = GameObject.Find("ranger3").GetComponent<Transform>();
        }
        
       

    }


    private void OnDisable()
    {
        if (this.gameObject.name == "missleR1")
        {
            go_Missle.SetActive(false);
            missleTransform.position = ranger1Transform.position;
        }
        if (this.gameObject.name == "missleR2")
        {
            go_Missle.SetActive(false);
            missleTransform.position = ranger2Transform.position;
        }
        if (this.gameObject.name == "missleR3")
        {
            go_Missle.SetActive(false);
            missleTransform.position = ranger3Transform.position;
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
            missleTransform.position = missleContainerTransform.position;

        }

        if (collision.gameObject.tag == "ASTEROID")

        {
            Debug.Log("MISSLE HITS ASTEROID");
            explosionTransform.position = missleTransform.position;
            Instantiate(go_Explosion, v3_missle, new Quaternion());
            go_Missle.SetActive(false);
            missleTransform.position = missleContainerTransform.position;

        }


        if (collision.gameObject.tag == "ASTEROID2")

        {
            Debug.Log("MISSLE HITS ASTEROID2");
            explosionTransform.position = missleTransform.position;
            Instantiate(go_Explosion, v3_missle, new Quaternion());
            go_Missle.SetActive(false);
            missleTransform.position = missleContainerTransform.position;

        }

    }


    private void FixedUpdate()
    {

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
