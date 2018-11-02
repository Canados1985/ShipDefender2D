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
    public GameObject go_RepairButton;
    public GameObject go_LevelUpButton;

    public GameObject go_LevelUp2;
    public GameObject go_TexttLevelUp2;

    public GameObject go_LevelUp3;
    public GameObject go_TexttLevelUp3;


    void Start () {

        cl_PanelUserControl = this;

        go_HarvesterButton.SetActive(false);
        go_ScoutButton.SetActive(false);
        go_RangerButton.SetActive(false);
        go_CorsairButton.SetActive(false);
        go_DestroyerButton.SetActive(false);
        go_RepairButton.SetActive(false);
        go_LevelUpButton.SetActive(false);


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

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 5)
        {
            go_HarvesterButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 5)
        {
            go_HarvesterButton.SetActive(false);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy >=15)
        {
            go_ScoutButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 15)
        {
            go_ScoutButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 25)
        {
            go_RangerButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 25)
        {
            go_RangerButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 35)
        {
            go_CorsairButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 35)
        {
            go_CorsairButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 45)
        {
            go_DestroyerButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 45)
        {
            go_DestroyerButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 50)
        {
            go_RepairButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 50)
        {
            go_RepairButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 100 && MainStation.cl_MainStation.b_baseLevel2Update == false)
        {
            go_LevelUpButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 100 && MainStation.cl_MainStation.b_baseLevel2Update == false)
        {
            go_LevelUpButton.SetActive(false);
        }

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 150 && MainStation.cl_MainStation.b_baseLevel2Update == true)
        {
            go_LevelUpButton.SetActive(true);
        }
        if (MainStation.cl_MainStation.f_mainStationEnergy < 150 && MainStation.cl_MainStation.b_baseLevel2Update == true)
        {
            go_LevelUpButton.SetActive(false);
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
