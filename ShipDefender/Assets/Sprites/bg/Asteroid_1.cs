using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_1 : MonoBehaviour {


    public static Asteroid_1 cl_Asteroid1;

    public GameObject go_Asteroid1;
    public Transform Asteroid1Transform;
    public Transform SP_Transform;

    float f_counter = 0;

	void Start () {

        cl_Asteroid1 = this;

        //go_Asteroid1 = GameObject.Find("asteroid1");
        //Asteroid1Transform = GameObject.Find("asteroid1").transform;
        SP_Transform = GameObject.Find("SP_Asteroid").transform;


        //Asteroid1Transform.position = SP_Transform.position;

        float f_randomScale;
        f_randomScale = Random.Range(0f, 3f);
        if (f_randomScale < 1) { Asteroid1Transform.localScale = new Vector3(4, 4, 4); }
        if (f_randomScale >= 2) { Asteroid1Transform.localScale = new Vector3(3, 3, 3); }
        if (f_randomScale > 3) { Asteroid1Transform.localScale = new Vector3(2, 2, 2); }
        
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "missleR1" || collision.gameObject.name == "missleR2" || collision.gameObject.name == "missleR2")
        {

            if (collision.gameObject.name == "missleR1")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;
             
                DestroyAsteroid();
            }
            if (collision.gameObject.name == "missleR2")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
              
                DestroyAsteroid();
            }
            if (collision.gameObject.name == "missleR3")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
               
                DestroyAsteroid();
            }

            DestroyAsteroid();
        }
        if (collision.gameObject.name == "bulletSC1" || collision.gameObject.name == "bulletSC2" || collision.gameObject.name == "bulletSC3" || collision.gameObject.name == "bulletSC4")
        {
            f_counter = f_counter + 1;

        }

    }


    public void DestroyAsteroid()
    {
        Destroy(this.gameObject);
    }


    void Update () {


        if (f_counter >= 10)
        {
            DestroyAsteroid();
            f_counter = 0;
        }


        go_Asteroid1.transform.Translate(new Vector3(-0.005f, 0, 0));

        if (go_Asteroid1.transform.position.x < -30f) { Destroy(go_Asteroid1); } 
    }
}
