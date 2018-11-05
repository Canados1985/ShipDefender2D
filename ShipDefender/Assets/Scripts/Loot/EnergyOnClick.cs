using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOnClick : MonoBehaviour {

    public GameObject go_EnergyInst;
    public GameObject go_Text;

    public Rigidbody2D rb_Energy;

    public Transform energyTransform;
    private Vector3 v3_Energy;

   
    public bool b_IsCollecting = false;
    public bool b_IsBusy = false;

    private float f_counter = 5f;
 
    void Start () {

       go_EnergyInst.gameObject.name = "energy";
       b_IsCollecting = false;
    }



    private void FixedUpdate()
    {
        if (this.b_IsCollecting == true)
        {
            f_counter -= Time.deltaTime;
        }
        if (f_counter <= 0)
        {
            Instantiate(go_Text, this.v3_Energy, new Quaternion());
            
            this.b_IsCollecting = false;
            MainStation.cl_MainStation.f_mainStationEnergy = MainStation.cl_MainStation.f_mainStationEnergy + 10;
            f_counter = 10f;
            Destroy(this.gameObject);

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "harvestergun") // < ---- I need to add bool from Harvester
        {
            this.b_IsCollecting = true;
        }
    }


    void Update () {

        v3_Energy.x = energyTransform.position.x;
        v3_Energy.y = energyTransform.position.y;
        v3_Energy.z = energyTransform.position.z;

        //Debug.Log("EnergyTranform.x" + energyTransform.position.x);

        if (this.b_IsCollecting == false && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {

            go_EnergyInst.transform.Translate(new Vector3(-0.005f, 0, 0));
            if (go_EnergyInst.transform.position.x < -30f)
            { Destroy(this.gameObject); }
        }

	}
    

}
