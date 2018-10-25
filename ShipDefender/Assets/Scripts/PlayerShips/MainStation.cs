using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainStation : MonoBehaviour {

    public static MainStation cl_MainStation;

    public GameObject go_MainStation;
    public GameObject go_MainStationLevel2;
    public GameObject go_MainStationLevel3;
    public Transform MainStationTransform;


    private bool b_turnBack = false;

   
    public float f_mainStationHealth;
    public float f_mainStationHealthMaxLevel1 = 1000;
    public float f_mainStationHealthMaxLevel2 = 1500;
    public float f_mainStationHealthMaxLevel3 = 2000;


    public float f_mainStationEnergy = 30;
    public float f_mainStationEnergyMaxLevel1 = 100;
    public float f_mainStationEnergyMaxLevel2 = 150;
    public float f_mainStationEnergyMaxLevel3 = 200;
    public int i_mainBaseLevel = 0;
   


    public Text stationHealth;
    public Text stationEnergy;
    public GameObject energyBAR;
    public GameObject healthBAR;


    public bool b_baseLevel2Update = false;
    public bool b_baseLevel3Update = false;

    private void Awake()
    {

        f_mainStationHealth = 1000;
        f_mainStationEnergy = 30;
    }


    void Start () {

       cl_MainStation = this;

        go_MainStation = GameObject.Find("MainStation");
        MainStationTransform = go_MainStation.GetComponent<Transform>();

        go_MainStationLevel2.SetActive(false);
        go_MainStationLevel3.SetActive(false);
    }


    public void ScoutPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 15;
 
    }

    public void RangerPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 25;
    }

    public void CorsairPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 35;
    }

    public void DestroyerPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 45;
    }

    public void RepairPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 50;
    }

    public void UpgradePrice()
    {
        if (go_MainStationLevel2.activeSelf == false && f_mainStationEnergy >= 100)
        {
            f_mainStationEnergy = f_mainStationEnergy - 100;
            go_MainStationLevel2.SetActive(true);
            f_mainStationHealth = 1500;
            
            b_baseLevel2Update = true;
        }
        if (go_MainStationLevel2.activeSelf == true && f_mainStationEnergy >= 150)
        {
            f_mainStationEnergy = f_mainStationEnergy - 100;
            go_MainStationLevel3.SetActive(true);
            f_mainStationHealth = 2000;
            b_baseLevel3Update = true;
        }

    }



    private void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            f_mainStationHealth = f_mainStationHealth - 15;


        }
        if (Input.GetKey(KeyCode.Q))
        {
            f_mainStationEnergy = f_mainStationEnergy - 5;
        }
        if (Input.GetKey(KeyCode.E))
        {
            f_mainStationEnergy = f_mainStationEnergy + 5;
        }




        if (!b_baseLevel2Update && !b_baseLevel3Update)
        {

            healthBAR.transform.localScale = new Vector3(f_mainStationHealth / f_mainStationHealthMaxLevel1, 1, 1);

            if (f_mainStationHealth > 1000)
            {
                f_mainStationHealth = 1000;
            }
            if (f_mainStationHealth < 0)
            {
                f_mainStationHealth = 0;
            }
        }
        if (b_baseLevel2Update && !b_baseLevel3Update)
        {

            healthBAR.transform.localScale = new Vector3(f_mainStationHealth / f_mainStationHealthMaxLevel1 / 1.5f, 1, 1);

            if (f_mainStationHealth > 1500)
            {
                f_mainStationHealth = 1500;
            }
            if (f_mainStationHealth < 0)
            {
                f_mainStationHealth = 0;
            }
        }
        if (b_baseLevel3Update && b_baseLevel3Update)
        {

            healthBAR.transform.localScale = new Vector3(f_mainStationHealth / f_mainStationHealthMaxLevel1 / 2.0f, 1, 1);

            if (f_mainStationHealth > 2000)
            {
                f_mainStationHealth = 2000;
            }
        }









        if (!b_baseLevel2Update && !b_baseLevel3Update)
        {

                energyBAR.transform.localScale = new Vector3(f_mainStationEnergy / f_mainStationEnergyMaxLevel1, 1, 1);

            if (f_mainStationEnergy > 100)
            {
                f_mainStationEnergy = 100;
            }
            if (f_mainStationEnergy < 0)
            {
                f_mainStationEnergy = 0;
            }
        }
        if (b_baseLevel2Update && !b_baseLevel3Update)
        {

                energyBAR.transform.localScale = new Vector3(f_mainStationEnergy / f_mainStationEnergyMaxLevel1 / 1.5f, 1, 1);

            if (f_mainStationEnergy > 150)
            {
                f_mainStationEnergy = 150;
            }
            if (f_mainStationEnergy < 0)
            {
                f_mainStationEnergy = 0;
            }
        }
        if (b_baseLevel3Update && b_baseLevel3Update)
        {

                energyBAR.transform.localScale = new Vector3(f_mainStationEnergy / f_mainStationEnergyMaxLevel1 / 2f, 1, 1);

            if (f_mainStationEnergy > 200)
            {
                f_mainStationEnergy = 200;
            }
        }




        if (f_mainStationHealth <= 0)
        {
            f_mainStationHealth = 0;
            Debug.Log("GAME OVER");
        }
        if (f_mainStationEnergy <= 0)
        {
            f_mainStationEnergy = 0;
            
        }


        Debug.Log(f_mainStationEnergy);


        stationHealth.text = f_mainStationHealth.ToString();
        stationEnergy.text = f_mainStationEnergy.ToString();

        if (MainStationTransform.position.z > 5f)

        {
            b_turnBack = true;
        }

        if (MainStationTransform.position.z < -4.5f)

        {
            b_turnBack = false;
        }

        if (b_turnBack)
        {
            go_MainStation.transform.Rotate(new Vector3(0, -0.015f, 0), Space.World);
            go_MainStation.transform.Translate(new Vector3(0, 0, -0.00055f));

            //Debug.Log(MainStationTransform.position.z);
        }
        if (!b_turnBack)
        {
            go_MainStation.transform.Rotate(new Vector3(0, -0.015f, 0), Space.World);
            go_MainStation.transform.Translate(new Vector3(0, 0, 0.00055f));

            //Debug.Log(MainStationTransform.position.z);
        }


    }
}
