using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{

    public static ufo cl_ufo;

    public GameObject go_ufo;
    public Transform ufoTransform;

    public Transform mainStationTransform;
    private float f_chaseRange = 200f;

    public GameObject go_EnergyInst;

    public Vector3 v3_UFO;

    public Transform SP_UFOTransform;

    float f_counter = 0;

    float f_rotationSpeed = 2f;
    float f_speed = 2f;

    void Start()
    {

        cl_ufo = this;


        if (this.gameObject.name == "ufo1")
        {
            go_ufo = GameObject.Find("ufo1");
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;
            //ufoTransform.position = SP_UFOTransform.position;

        }
        if (this.gameObject.name == "ufo2")
        {
            go_ufo = GameObject.Find("ufo2");
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;
            //ufoTransform.position = SP_UFOTransform.position;
        }
        if (this.gameObject.name == "ufo3")
        {
            go_ufo = GameObject.Find("ufo3");
            ufoTransform = go_ufo.GetComponent<Transform>();
            SP_UFOTransform = GameObject.Find("SP_UFO").transform;
            //ufoTransform.position = SP_UFOTransform.position;
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
            }
            if (col.gameObject.name == "missleR2")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
            if (col.gameObject.name == "missleR3")
            {
                //Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
        }

       /* if ((col.gameObject.name == "missleR1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR3" && this.gameObject.tag == "UFO"))

        {
            if (col.gameObject.name == "missleR1")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
            if (col.gameObject.name == "missleR2")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
            if (col.gameObject.name == "missleR3")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
        }
        if ((col.gameObject.name == "missleR1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "missleR3" && this.gameObject.tag == "UFO"))

        {
            if (col.gameObject.name == "missleR1")
            {
              //  Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
            if (col.gameObject.name == "missleR2")
            {
               // Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
            if (col.gameObject.name == "missleR3")
            {
              //  Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
                Debug.Log("MISSLE HITS UFO1");
                UFO1Destroyed();
            }
        }*/

        if ((col.gameObject.name == "bulletSC1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC3" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC4" && this.gameObject.tag == "UFO"))

        {

            f_counter = f_counter + 1;

            Debug.Log("BULLET HITS UFO1");

            if (f_counter >= 20)
            {
                if (col.gameObject.name == "bulletSC1")
                {
                    Scout.cl_Scout.b_IsAimed_Scout1 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC2")
                {
                    Scout.cl_Scout.b_IsAimed_Scout2 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC3")
                {
                    Scout.cl_Scout.b_IsAimed_Scout3 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC4")
                {
                    Scout.cl_Scout.b_IsAimed_Scout4 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
            }

        }
        if ((col.gameObject.name == "bulletSC1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC3" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC4" && this.gameObject.tag == "UFO"))

        {

            f_counter = f_counter + 1;

            Debug.Log("BULLET HITS UFO1");

            if (f_counter >= 20)
            {
                if (col.gameObject.name == "bulletSC1")
                {
                    Scout.cl_Scout.b_IsAimed_Scout1 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC2")
                {
                    Scout.cl_Scout.b_IsAimed_Scout2 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC3")
                {
                    Scout.cl_Scout.b_IsAimed_Scout3 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC4")
                {
                    Scout.cl_Scout.b_IsAimed_Scout4 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
            }



        }
        if ((col.gameObject.name == "bulletSC1" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC2" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC3" && this.gameObject.tag == "UFO") || (col.gameObject.name == "bulletSC4" && this.gameObject.tag == "UFO"))

        {

            f_counter = f_counter + 1;

            Debug.Log("BULLET HITS UFO1");

            if (f_counter >= 20)
            {
                if (col.gameObject.name == "bulletSC1")
                {
                    Scout.cl_Scout.b_IsAimed_Scout1 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC2")
                {
                    Scout.cl_Scout.b_IsAimed_Scout2 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC3")
                {
                    Scout.cl_Scout.b_IsAimed_Scout3 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
                if (col.gameObject.name == "bulletSC4")
                {
                    Scout.cl_Scout.b_IsAimed_Scout4 = false;
                    Scout.cl_Scout.b_IsShoting = false;
                    Scout.cl_Scout.gunSpriteInst.SetActive(false);
                    f_counter = 0;
                    UFO1Destroyed();
                }
            }

        }



    }

    public void UFO1Destroyed()
    {
        Instantiate(go_EnergyInst, ufoTransform.position, new Quaternion());
        //ufoTransform.position = SP_UFOTransform.position;
        //go_ufo.SetActive(false);
        Destroy(this.gameObject);
    }

    void Update()
    {
        //Get distance to the target
        float distanceToTarget = Vector3.Distance(transform.position, mainStationTransform.position);

        if (distanceToTarget < f_chaseRange && Vector2.Distance(transform.position, mainStationTransform.position) > 15)
        {
            //Start chasing - turn and move
            Vector3 targetDir = mainStationTransform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, f_rotationSpeed);

            transform.Translate(Vector3.up * Time.deltaTime * f_speed);
        }


    }

}