using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvesterGun : MonoBehaviour {

     public GameObject go_HarvesterGunSprite;

     public UnknownRes go_UnknownResRef;
     public EnergyOnClick go_EnergyRef;  

	void Start () {

        go_HarvesterGunSprite.SetActive(false);


    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        Harvester tempHarvester = gameObject.transform.parent.GetComponent<Harvester>();

        if (collision.gameObject.tag == "ENERGY")
        {
            tempHarvester.b_IsWorking = true;
            go_EnergyRef.GetComponent<EnergyOnClick>().b_IsCollecting = true;
            go_HarvesterGunSprite.SetActive(true);
            
        }
        if (collision.gameObject.tag == "UNKNOWNRES")

        {
           tempHarvester.b_IsWorking = true;
            go_UnknownResRef.GetComponent<UnknownRes>().b_IsCollecting = true;
            go_HarvesterGunSprite.SetActive(true);
        }
    }

     private void OnTriggerExit2D(Collider2D collision)
    {
        Harvester tempHarvester = gameObject.transform.parent.GetComponent<Harvester>();

        if (collision.gameObject.tag == "ENERGY")

        {
           tempHarvester.b_IsWorking = false;
           tempHarvester.b_IsBusy = false;
            go_EnergyRef.GetComponent<EnergyOnClick>().b_IsCollecting = false;
            go_HarvesterGunSprite.SetActive(false);

        }
        if (collision.gameObject.tag == "UNKNOWNRES")

        {
           tempHarvester.b_IsWorking = false;
           tempHarvester.b_IsBusy = false;
            go_UnknownResRef.GetComponent<UnknownRes>().b_IsCollecting = false;
            go_HarvesterGunSprite.SetActive(false);
        }



    }



    void Update () {
		
	}
}
