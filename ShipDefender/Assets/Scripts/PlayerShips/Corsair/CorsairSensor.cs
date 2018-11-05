using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsairSensor : MonoBehaviour {


    public bool b_colIsUFO1 = false;
    public bool b_colIsUFO2 = false;
    public bool b_colIsUFO3 = false;

    public bool b_colIsAsteriod1 = false;
    public bool b_colIsAsteroid2 = false;

    float f_counter = 2;

    float f_missleSensor = 5;

    void Start () {
		
	}


    private void OnTriggerStay2D(Collider2D collision)
    {
        Corsair tempCorsair = gameObject.transform.parent.GetComponent<Corsair>();
        
        if (collision.gameObject.name == "ufo1(Clone)" && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {
                 

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo1TransformTarget.position = collision.gameObject.transform.position;

                
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }

        }
        if (collision.gameObject.name == "ufo2(Clone)" && b_colIsUFO1 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {
              

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo2TransformTarget.position = collision.gameObject.transform.position;


                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }

        }
        if (collision.gameObject.name == "ufo3(Clone)" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {
 

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo3TransformTarget.position = collision.gameObject.transform.position;

                b_colIsUFO3 = true;

            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                tempCorsair.b_chasingUFO = true;
                tempCorsair.ufo3TransformTarget.position = collision.gameObject.transform.position;


                b_colIsUFO3 = true;

            }

        }

        if (collision.gameObject.tag == "ASTEROID" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {

                tempCorsair.b_chasingAsteroid = true;
                tempCorsair.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                tempCorsair.b_chasingAsteroid = true;
                tempCorsair.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }

        }
        if (collision.gameObject.tag == "ASTEROID2" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false)
        {
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {

                tempCorsair.b_chasingAsteroid = true;
                tempCorsair.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                tempCorsair.b_chasingAsteroid = true;
                tempCorsair.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Corsair tempCorsair = gameObject.transform.parent.GetComponent<Corsair>();
        if (collision.gameObject.name == "ufo1(Clone)")
        {
            tempCorsair.b_chasingUFO = false;
            b_colIsUFO1 = false;
        }
        if (collision.gameObject.name == "ufo2(Clone)")
        {
            tempCorsair.b_chasingUFO = false;
            b_colIsUFO2 = false;
        }
        if (collision.gameObject.name == "ufo3(Clone)")
        {
            tempCorsair.b_chasingUFO = false;
            b_colIsUFO3 = false;
        }

        if (collision.gameObject.tag == "ASTEROID")
        {
            tempCorsair.b_chasingAsteroid = false;
            b_colIsAsteriod1 = false;
        }

        if (collision.gameObject.tag == "ASTEROID2")
        {
            tempCorsair.b_chasingAsteroid = false;
            b_colIsAsteroid2 = false;
        }
    }


    private void FixedUpdate()
    {
        MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
        MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


        if ((tempMissleSeeker.b_pickTarger1UFO1 == true || tempMissleSeeker.b_pickTarger2UFO2 == true || tempMissleSeeker.b_pickTarger3UFO3 == true || tempMissleSeeker.b_pickTarger4Asteroid1 == true || tempMissleSeeker.b_pickTarger5Asteroid2 == true) ||
            (temp2MissleSeeker.b_pickTarger1UFO1 == true || temp2MissleSeeker.b_pickTarger2UFO2 == true || temp2MissleSeeker.b_pickTarger3UFO3 == true || temp2MissleSeeker.b_pickTarger4Asteroid1 == true || temp2MissleSeeker.b_pickTarger5Asteroid2 == true))

        {
            f_missleSensor -= Time.deltaTime;
        }
        if(f_missleSensor <= 0)
        {
            tempMissleSeeker.b_pickTarger1UFO1 = false;
            tempMissleSeeker.b_pickTarger2UFO2 = false;
            tempMissleSeeker.b_pickTarger3UFO3 = false;
            tempMissleSeeker.b_pickTarger4Asteroid1 = false;
            tempMissleSeeker.b_pickTarger5Asteroid2 = false;

            temp2MissleSeeker.b_pickTarger1UFO1 = false;
            temp2MissleSeeker.b_pickTarger2UFO2 = false;
            temp2MissleSeeker.b_pickTarger3UFO3 = false;
            temp2MissleSeeker.b_pickTarger4Asteroid1 = false;
            temp2MissleSeeker.b_pickTarger5Asteroid2 = false;

            f_missleSensor = 5;

        }


        if (b_colIsUFO1 == true || b_colIsUFO2 == true || b_colIsUFO3 == true || b_colIsAsteriod1 == true || b_colIsAsteroid2 == true)
        {
            f_counter -= Time.deltaTime;

        }
        if (f_counter <= 0)
        {


            Corsair tempCorsair = gameObject.transform.parent.GetComponent<Corsair>();
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")
            {
                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempCorsair.b_chasingUFO = false;
                tempCorsair.b_chasingAsteroid = false;

                f_counter = 2;
            }
            if (this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                
                tempCorsair.b_chasingUFO = false;
                tempCorsair.b_chasingAsteroid = false;


                f_counter = 2;
            }



        }
    }




}
