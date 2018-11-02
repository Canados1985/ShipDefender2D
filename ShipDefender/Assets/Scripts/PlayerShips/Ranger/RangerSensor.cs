using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerSensor : MonoBehaviour {

    public static RangerSensor cl_RangerSensor;


    public bool b_colIsUFO1 = false;
    public bool b_colIsUFO2 = false;
    public bool b_colIsUFO3 = false;

    public bool b_colIsAsteriod1 = false;
    public bool b_colIsAsteroid2 = false;

    float f_counter = 5;

    void Start() {

        cl_RangerSensor = this;

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ufo1(Clone)" && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            Ranger.cl_Ranger.b_chasingUFO = true;
            b_colIsUFO1 = true;
        }
        if (collision.gameObject.name == "ufo2(Clone)" && b_colIsUFO1 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            Ranger.cl_Ranger.b_chasingUFO = true;
            b_colIsUFO2 = true;
        }
        if (collision.gameObject.name == "ufo3(Clone)" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            Ranger.cl_Ranger.b_chasingUFO = true;
            b_colIsUFO3 = true;
        }

        if (collision.gameObject.tag == "ASTEROID" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteroid2 == false)
        {
            Ranger.cl_Ranger.b_chasingAsteroid = true;
            b_colIsAsteriod1 = true;
        }

        if (collision.gameObject.tag == "ASTEROID2" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false)
        {
            Ranger.cl_Ranger.b_chasingAsteroid = true;
            b_colIsAsteroid2 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ufo1(Clone)")
        {
            Ranger.cl_Ranger.b_chasingUFO = false;
            b_colIsUFO1 = false;
        }
        if (collision.gameObject.name == "ufo2(Clone)")
        {
            Ranger.cl_Ranger.b_chasingUFO = false;
            b_colIsUFO2 = false;
        }
        if (collision.gameObject.name == "ufo3(Clone)")
        {
            Ranger.cl_Ranger.b_chasingUFO = false;
            b_colIsUFO3 = false;
        }

        if (collision.gameObject.tag == "ASTEROID")
        {
            Ranger.cl_Ranger.b_chasingAsteroid = false;
            b_colIsAsteriod1 = false;
        }

        if (collision.gameObject.tag == "ASTEROID2")
        {
            Ranger.cl_Ranger.b_chasingAsteroid = false;
            b_colIsAsteroid2 = false;
        }
    }


    private void FixedUpdate()
    {
        if (b_colIsUFO1 == true || b_colIsUFO2 == true || b_colIsUFO3 == true || b_colIsAsteriod1 == true || b_colIsAsteroid2 == true)
        {
            f_counter -= Time.deltaTime;

        }
        if (f_counter <= 0)
        {
            Ranger.cl_Ranger.b_chasingUFO = false;
            Ranger.cl_Ranger.b_chasingAsteroid = false;

             b_colIsUFO1 = false;
             b_colIsUFO2 = false;
             b_colIsUFO3 = false;
             b_colIsAsteriod1 = false;
             b_colIsAsteroid2 = false;

    f_counter = 5;
        }
    }

}
