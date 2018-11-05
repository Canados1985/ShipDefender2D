using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerSensor : MonoBehaviour {

    public bool b_colIsUFO1 = false;
    public bool b_colIsUFO2 = false;
    public bool b_colIsUFO3 = false;

    public bool b_colIsAsteriod1 = false;
    public bool b_colIsAsteroid2 = false;

    float f_counter = 8;

    void Start() {


    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        Ranger tempRenger = gameObject.transform.parent.GetComponent<Ranger>();
        if (collision.gameObject.name == "ufo1(Clone)" && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO1 = true;

            }
        }
        if (collision.gameObject.name == "ufo2(Clone)" && b_colIsUFO1 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {

            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO2 = true;

            }
        }
        if (collision.gameObject.name == "ufo3(Clone)" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsAsteriod1 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                tempRenger.b_chasingUFO = true;
                tempRenger.ufo3TransformTarget.position = collision.gameObject.transform.position;
                b_colIsUFO3 = true;


            }
        }

        if (collision.gameObject.tag == "ASTEROID" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteroid2 == false)
        {
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid1TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteriod1 = true;

            }
        }
        if (collision.gameObject.tag == "ASTEROID2" && b_colIsUFO1 == false && b_colIsUFO2 == false && b_colIsUFO3 == false && b_colIsAsteriod1 == false)
        {
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                tempRenger.b_chasingAsteroid = true;
                tempRenger.asteroid2TransformTarget.position = collision.gameObject.transform.position;
                b_colIsAsteroid2 = true;

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Ranger tempRenger = gameObject.transform.parent.GetComponent<Ranger>();
        if (collision.gameObject.name == "ufo1(Clone)")
        {
            tempRenger.b_chasingUFO = false;
            b_colIsUFO1 = false;
        }
        if (collision.gameObject.name == "ufo2(Clone)")
        {
            tempRenger.b_chasingUFO = false;
            b_colIsUFO2 = false;
        }
        if (collision.gameObject.name == "ufo3(Clone)")
        {
            tempRenger.b_chasingUFO = false;
            b_colIsUFO3 = false;
        }

        if (collision.gameObject.tag == "ASTEROID")
        {
            tempRenger.b_chasingAsteroid = false;
            b_colIsAsteriod1 = false;
        }

        if (collision.gameObject.tag == "ASTEROID2")
        {
            tempRenger.b_chasingAsteroid = false;
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

            Ranger tempRenger = gameObject.transform.parent.GetComponent<Ranger>();
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger1")
            {
                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                tempRenger.b_chasingUFO = false;
                tempRenger.b_chasingAsteroid = false;
                f_counter = 8;
            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger2")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                f_counter = 8;
                tempRenger.b_chasingUFO = false;
                tempRenger.b_chasingAsteroid = false;
            }
            if (this.gameObject.GetComponentInParent<Ranger>().gameObject.name == "ranger3")
            {

                b_colIsUFO1 = false;
                b_colIsUFO2 = false;
                b_colIsUFO3 = false;
                b_colIsAsteriod1 = false;
                b_colIsAsteroid2 = false;
                f_counter = 8;
                tempRenger.b_chasingUFO = false;
                tempRenger.b_chasingAsteroid = false;
            }


        }
    }

}
