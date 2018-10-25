using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOnClick : MonoBehaviour {


    public GameObject go_EnergyInst;


	void Start () {
		
	}
	




	void Update () {


        go_EnergyInst.transform.Translate(new Vector3(-0.005f,0,0));

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 50.0f))
            {

                if (hit.transform != null)
                {
                    if (hit.transform.gameObject.name == "energy")
                    {
                        SetActiveFalse();
                    }

                }
            }
        }



	}


    private void SetActiveFalse()

    {
        go_EnergyInst.SetActive(false);
        MainStation.cl_MainStation.f_mainStationEnergy = MainStation.cl_MainStation.f_mainStationEnergy + 5;

    }
}
