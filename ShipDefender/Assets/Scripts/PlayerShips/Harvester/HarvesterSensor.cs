using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvesterSensor : MonoBehaviour {



    public bool b_colIsUnknownRes = false;
    public bool b_colIsEnergy = false;

    private float f_counter = 5f;

	void Start () {



    }


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ENERGY" && b_colIsUnknownRes == false)
        {
            Harvester tempHarvester = gameObject.transform.parent.GetComponent<Harvester>();

            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester1")
            {
                b_colIsEnergy = true;
                tempHarvester.b_IsFolowingToEnergy = true;
                tempHarvester.energyTransformTarget1.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester2")
            {
                b_colIsEnergy = true;
                tempHarvester.b_IsFolowingToEnergy = true;
                tempHarvester.energyTransformTarget1.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester3")
            {
                b_colIsEnergy = true;
                tempHarvester.b_IsFolowingToEnergy = true;
                tempHarvester.energyTransformTarget1.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester4")
            {
                b_colIsEnergy = true;
                tempHarvester.b_IsFolowingToEnergy = true;
                tempHarvester.energyTransformTarget1.position = collision.gameObject.transform.position;
            }

        }
        if (collision.gameObject.tag == "UNKNOWNRES" && b_colIsEnergy == false)
        {
            Harvester tempHarvester = gameObject.transform.parent.GetComponent<Harvester>();
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester1")
            {
                b_colIsUnknownRes = true;
                tempHarvester.b_IsFolowingToRes = true;
                tempHarvester.resTransformTarget2.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester2")
            {
                b_colIsUnknownRes = true;
                tempHarvester.b_IsFolowingToRes = true;
                tempHarvester.resTransformTarget2.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester3")
            {
                b_colIsUnknownRes = true;
                tempHarvester.b_IsFolowingToRes = true;
                tempHarvester.resTransformTarget2.position = collision.gameObject.transform.position;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester4")
            {
                b_colIsUnknownRes = true;
                tempHarvester.b_IsFolowingToRes = true;
                tempHarvester.resTransformTarget2.position = collision.gameObject.transform.position;
            }
        }
    }


    private void FixedUpdate()
    {
        if (b_colIsEnergy == true || b_colIsUnknownRes == true)
        {
            f_counter -= Time.deltaTime;

        }



        if (f_counter <= 0)
        {

            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester1")
            {
                f_counter = 5;
                b_colIsUnknownRes = false;
                b_colIsEnergy = false;
                
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester2")
            {
                f_counter = 5;
                b_colIsUnknownRes = false;
                b_colIsEnergy = false;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester3")
            {
                f_counter = 5;
                b_colIsUnknownRes = false;
                b_colIsEnergy = false;
            }
            if (this.gameObject.GetComponentInParent<Harvester>().gameObject.name == "harvester4")
            {
                f_counter = 5;
                b_colIsUnknownRes = false;
                b_colIsEnergy = false;
            }

            Harvester tempHarvester = gameObject.transform.parent.GetComponent<Harvester>();

            tempHarvester.b_IsFolowingToEnergy = false;
            tempHarvester.b_IsFolowingToRes = false;


            f_counter = 5;
        }
    }
}
