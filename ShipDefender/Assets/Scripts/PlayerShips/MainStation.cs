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

    public GameObject go_cursor;

    private bool b_turnBack = false;

   
    public float f_mainStationHealth;
    public float f_mainStationHealthMaxLevel1 = 1000;
    public float f_mainStationHealthMaxLevel2 = 1500;
    public float f_mainStationHealthMaxLevel3 = 2000;


    public float f_mainStationEnergy = 30;
    public float f_mainStationResource = 0;
    public float f_mainStationEnergyMaxLevel1 = 100;
    public float f_mainStationEnergyMaxLevel2 = 150;
    public float f_mainStationEnergyMaxLevel3 = 200;
    public int i_mainBaseLevel = 0;
   


    public Text stationHealth;
    public Text stationEnergy;
    public Text stationResource;
    public GameObject energyBAR;
    public GameObject healthBAR;


    public bool b_baseLevel2Update = false;
    public bool b_baseLevel3Update = false;

    private void Awake()
    {

        f_mainStationHealth = 1000;
        f_mainStationEnergy = 30;
        f_mainStationResource = 0;
    }


    void Start () {

         cl_MainStation = this;

        go_MainStation = GameObject.Find("MainStation");
        MainStationTransform = go_MainStation.GetComponent<Transform>();

        go_MainStationLevel2.SetActive(false);
        go_MainStationLevel3.SetActive(false);
        go_cursor.SetActive(false);
    }

    public void HarvesterPrice()
    {
        f_mainStationEnergy = f_mainStationEnergy - 5;

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
        if (!b_baseLevel2Update && !b_baseLevel3Update)
        {
            f_mainStationEnergy = f_mainStationEnergy - 50;
            f_mainStationHealth = 1000;
        }
        if (b_baseLevel2Update && !b_baseLevel3Update)
        {
            f_mainStationEnergy = f_mainStationEnergy - 100;
            f_mainStationHealth = 1500;
        }
        if (b_baseLevel3Update)
        {
            f_mainStationEnergy = f_mainStationEnergy - 150;
            f_mainStationHealth = 2000;
        }
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


    /*   private void OnTriggerEnter(Collider other)
       {
           if (other.gameObject.tag == "ASTEROID")
           {
               f_mainStationHealth = f_mainStationHealth - 15f;
               Asteroid_1.cl_Asteroid1.DestroyAsteroid();

           }
           if (other.gameObject.tag == "ASTEROID2")
           {
               f_mainStationHealth = f_mainStationHealth - 15f;
               Asteroid_2.cl_Asteroid2.DestroyAsteroid();
           }
       }
   */
    private void FixedUpdate()
    {
        
        f_mainStationEnergy += Time.deltaTime / 5;

    }

    private void Update()
    {
        // Temporary Input
        if (GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
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
            if (Input.GetKey(KeyCode.R))
            {
                f_mainStationResource = f_mainStationResource + 5;
            }
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
            GameStateManager.cl_GameStateManager.GameOver();
        }
        if (f_mainStationEnergy <= 0)
        {
            f_mainStationEnergy = 0;
            
        }
        if (f_mainStationResource >= 2000)
        {
            GameStateManager.cl_GameStateManager.GameWin();
        }

        //Debug.Log(f_mainStationEnergy);


        stationHealth.text = f_mainStationHealth.ToString();
        float temp = Mathf.Round(f_mainStationEnergy);
        stationEnergy.text = temp.ToString();
        stationResource.text = f_mainStationResource.ToString();

        if (MainStationTransform.position.y > 9.5f && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)

        {
            b_turnBack = true;
        }

        if (MainStationTransform.position.y < -10f && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)

        {
            b_turnBack = false;
        }

        if (b_turnBack && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {


            if (!b_baseLevel2Update && !b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, -0.00055f, 0));
            }
            if (b_baseLevel2Update && !b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, -0.00155f, 0));
            }
            if (b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, -0.00255f, 0));
            }

            //Debug.Log(MainStationTransform.position.z);
        }
        if (!b_turnBack && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {

            if (!b_baseLevel2Update && !b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, 0.00055f, 0));
            }
            if (b_baseLevel2Update && !b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, 0.00155f, 0));
            }
            if (b_baseLevel3Update)
            {
                go_MainStation.transform.Rotate(new Vector3(0, 0, -0.05f), Space.World);
                go_MainStation.transform.Translate(new Vector3(0, 0.00255f, 0));
            }

            //Debug.Log(MainStationTransform.position.z);
        }


        if (Input.GetMouseButtonDown(0) && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10000.0f))
            {

                if (hit.transform != null)
                {
                    if (hit.transform.gameObject.name == "MainStation")
                    {
                        
                        PanelUserControl.cl_PanelUserControl.SetPanelActive();
                        go_cursor.SetActive(true);
                    }

                }


            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            PanelUserControl.cl_PanelUserControl.SetPanelNotActive();
            go_cursor.SetActive(false);
        }


        }
}
