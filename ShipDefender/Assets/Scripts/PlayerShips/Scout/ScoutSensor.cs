using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutSensor : MonoBehaviour {


    public bool b_colIsUFO1 = false;
    public bool b_colIsUFO2 = false;
    public bool b_colIsUFO3 = false;

    public bool b_colIsAsteriod1 = false;
    public bool b_colIsAsteroid2 = false;

    public float f_counter = 0.2f;


    void Start () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();
        if (collision.gameObject.name == "ufo1(Clone)" && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
        }
        if (collision.gameObject.name == "ufo2(Clone)" && b_colIsUFO1 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
        }
        if (collision.gameObject.name == "ufo3(Clone)" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;


            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                tempScout.b_chasingUFO = true;
                tempScout.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;


            }
        }

        if (collision.gameObject.tag == "ASTEROID" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
        }
        if (collision.gameObject.tag == "ASTEROID2" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false)
        {
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                tempScout.b_chasingAsteroid = true;
                tempScout.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();
        if (collision.gameObject.name == "ufo1(Clone)")
        {
            tempScout.b_chasingUFO = false;
            b_colIsUFO1 = false;
        }
        if (collision.gameObject.name == "ufo2(Clone)")
        {
            tempScout.b_chasingUFO = false;
            b_colIsUFO2 = false;
        }
        if (collision.gameObject.name == "ufo3(Clone)")
        {
            tempScout.b_chasingUFO = false;
            b_colIsUFO3 = false;
        }

        if (collision.gameObject.tag == "ASTEROID")
        {
            tempScout.b_chasingAsteroid = false;
            b_colIsAsteriod1 = false;
        }

        if (collision.gameObject.tag == "ASTEROID2")
        {
            tempScout.b_chasingAsteroid = false;
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

            Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout1")
            {
                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempScout.b_chasingUFO = false;
                tempScout.b_chasingAsteroid = false;
                tempScout.b_GunSound = false;
                f_counter = 0.2f;
            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout2")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempScout.b_chasingUFO = false;
                tempScout.b_chasingAsteroid = false;
                tempScout.b_GunSound = false;
                f_counter = 0.2f;
            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout3")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempScout.b_GunSound = false;
                tempScout.b_chasingUFO = false;
                tempScout.b_chasingAsteroid = false;
                f_counter = 0.2f;
            }
            if (this.gameObject.GetComponentInParent<Scout>().gameObject.name == "scout4")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempScout.b_GunSound = false;
                tempScout.b_chasingUFO = false;
                tempScout.b_chasingAsteroid = false;
                f_counter = 0.2f;
            }


        }
    }

}
