using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOnClick : MonoBehaviour {

    public static EnergyOnClick cl_EnergyOnClick;

    public GameObject go_EnergyInst;
    public GameObject go_Text;

    public Rigidbody2D rb_Energy;

    public Transform energyTransform;
    private Vector3 v3_Energy;

    public bool b_JustOne = false;
    public bool b_IsCollecting = false;

    private float f_counter = 10f;
 
    void Start () {

        cl_EnergyOnClick = this;
        go_EnergyInst.gameObject.name = "energy";
    }



    private void FixedUpdate()
    {
        if (b_IsCollecting == true)
        {
            f_counter -= Time.deltaTime;
        }
        if (f_counter <= 0)
        {
            Instantiate(go_Text, this.v3_Energy, new Quaternion());
            f_counter = 10f;
            MainStation.cl_MainStation.f_mainStationEnergy = MainStation.cl_MainStation.f_mainStationEnergy + 5;
            Destroy(this.gameObject);

        }
    }

    void Update () {

        v3_Energy.x = energyTransform.position.x;
        v3_Energy.y = energyTransform.position.y;
        v3_Energy.z = energyTransform.position.z;

        //Debug.Log("EnergyTranform.x" + energyTransform.position.x);

        if (b_IsCollecting == false)
        { go_EnergyInst.transform.Translate(new Vector3(-0.005f, 0, 0)); }
        

        /* if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 50.0f))
            {

                if (hit.transform != null)
                {
                    if (hit.transform.gameObject.name == "energy" && b_JustOne == false)
                    {
                        Debug.Log("how many times from energy click");
                        //b_JustOne = true;
                        //Destroy(go_EnergyInst);
                        v3_Energy = hit.transform.position;
                        Instantiate(go_Text, v3_Energy, new Quaternion());
                        SetActiveFalse();
                        hit.transform.gameObject.SetActive(false);
                    }

                }
            }
        }


*/
	}
    

    private void SetActiveFalse()

    {


        go_EnergyInst.SetActive(false);
        MainStation.cl_MainStation.f_mainStationEnergy = MainStation.cl_MainStation.f_mainStationEnergy + 5;

    }
}
