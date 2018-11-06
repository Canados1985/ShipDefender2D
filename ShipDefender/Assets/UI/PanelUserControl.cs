using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelUserControl : MonoBehaviour {

    public static PanelUserControl cl_PanelUserControl;

    public GameObject go_PanelUserControl;

    public GameObject mainShipInst;

    public GameObject go_HarvesterButton;
    public GameObject go_ScoutButton;
    public GameObject go_RangerButton;
    public GameObject go_CorsairButton;
    public GameObject go_DestroyerButton;

    public GameObject go_HarvesterButtonLimit;
    public GameObject go_ScoutButtonLimit;
    public GameObject go_RangerButtonLimit;
    public GameObject go_CorsairButtonLimit;
    public GameObject go_DestroyerButtonLimit;



    public GameObject go_RepairButton;
    public GameObject go_LevelUpButton;


    public GameObject go_HarvesterButtonMoreEnergy;
    public GameObject go_ScoutButtonMoreEnergy;
    public GameObject go_RangerButtonMoreEnergy;
    public GameObject go_CorsairButtonMoreEnergy;
    public GameObject go_DestroyerButtonMoreEnergy;
    public GameObject go_RepairButtonMoreEnergy;
    public GameObject go_LevelUpButtonMoreEnergy;


    public GameObject go_LevelUp2;
    public GameObject go_TexttLevelUp2;

    public GameObject go_LevelUp3;
    public GameObject go_TexttLevelUp3;


    void Start () {

        cl_PanelUserControl = this;

        /*
        go_HarvesterButton.SetActive(false);
        go_ScoutButton.SetActive(false);
        go_RangerButton.SetActive(false);
        go_CorsairButton.SetActive(false);
        go_DestroyerButton.SetActive(false);
        go_RepairButton.SetActive(false);
        go_LevelUpButton.SetActive(false);
        */



        go_HarvesterButtonLimit.SetActive(false);
        go_ScoutButtonLimit.SetActive(false);
        go_RangerButtonLimit.SetActive(false);
        go_CorsairButtonLimit.SetActive(false);
        go_DestroyerButtonLimit.SetActive(false);
        go_LevelUp3.SetActive(false);
        go_TexttLevelUp3.SetActive(false);


    }



    public void SetPanelActive()
    {
        go_PanelUserControl.SetActive(true);
    }

    public void SetPanelNotActive()
    {
        go_PanelUserControl.SetActive(false);
    }

    void Update () {

        //Harvester Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 5)
        {
            go_HarvesterButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 5)
        {
            go_HarvesterButtonMoreEnergy.SetActive(true);
        }
        //Scout Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >=15)
        {
            go_ScoutButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 15)
        {
            go_ScoutButtonMoreEnergy.SetActive(true);
        }
        //Ranger Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 25)
        {
            go_RangerButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 25)
        {
            go_RangerButtonMoreEnergy.SetActive(true);
        }
        // Corsair Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 35)
        {
            go_CorsairButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 35)
        {
            go_CorsairButtonMoreEnergy.SetActive(true);
        }
        // Destroyer Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 45)
        {
            go_DestroyerButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 45)
        {
            go_DestroyerButtonMoreEnergy.SetActive(true);
        }
        // Repair Base Button -->
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 50)
        {
            go_RepairButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 50)
        {
            go_RepairButtonMoreEnergy.SetActive(true);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 100 && MainStation.cl_MainStation.b_baseLevel2Update == false)
        {
            go_LevelUpButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 100 && MainStation.cl_MainStation.b_baseLevel2Update == false)
        {
            go_LevelUpButtonMoreEnergy.SetActive(true);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 150 && MainStation.cl_MainStation.b_baseLevel2Update == true)
        {
            go_LevelUpButtonMoreEnergy.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 150 && MainStation.cl_MainStation.b_baseLevel2Update == true)
        {
            go_LevelUpButtonMoreEnergy.SetActive(true);
        }



        if (MainStation.cl_MainStation.b_baseLevel2Update)
        {

            go_LevelUp2.SetActive(false);
            go_TexttLevelUp2.SetActive(false);
            go_LevelUp3.SetActive(true);
            go_TexttLevelUp3.SetActive(true);
        }

    }
}
