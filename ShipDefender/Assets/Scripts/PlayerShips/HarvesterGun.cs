using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvesterGun : MonoBehaviour {


    public GameObject go_HarvesterGunSprite;


	void Start () {
        go_HarvesterGunSprite.SetActive(false);

    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ENERGY")
        {
            Harvester.cl_Harvester.b_IsWorking = true;
            EnergyOnClick.cl_EnergyOnClick.b_IsCollecting = true;
            //Harvester.cl_Harvester.rb_Harvester.velocity = Vector3.zero;
            go_HarvesterGunSprite.SetActive(true);
            
        }
        if (collision.gameObject.tag == "UNKNOWNRES")

        {
            Harvester.cl_Harvester.b_IsWorking = true;
            UnknownRes.cl_UnknownRes.b_IsCollecting = true;
            //Harvester.cl_Harvester.rb_Harvester.velocity = Vector3.zero;
            go_HarvesterGunSprite.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ENERGY")

        {
            Harvester.cl_Harvester.b_IsWorking = false;
            Harvester.cl_Harvester.b_IsBusy = false;
            EnergyOnClick.cl_EnergyOnClick.b_IsCollecting = false;
            go_HarvesterGunSprite.SetActive(false);

        }
        if (collision.gameObject.tag == "UNKNOWNRES")

        {
            Harvester.cl_Harvester.b_IsWorking = false;
            Harvester.cl_Harvester.b_IsBusy = false;
            UnknownRes.cl_UnknownRes.b_IsCollecting = false;
            go_HarvesterGunSprite.SetActive(false);
        }



    }



    void Update () {
		
	}
}
