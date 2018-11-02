using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager cl_GameManager;

    public GameObject HarvesterButton; // UI button

    public GameObject mainStationInst;

    public GameObject missleSeekerInst;

    public GameObject harvesterInst;
    public GameObject scoutInst;
    public GameObject rangerInst;
    public GameObject corsairInst;
    public GameObject destroyerInst;


    [HideInInspector]


    public List<GameObject> go_missleSeekerList;
    private GameObject missleSeekerContainer;

    public List<GameObject> go_UFObulletList;
    private GameObject UFObulletContainer;

    public List<GameObject> go_HarvesterList;
    private GameObject harvesterContainer;

    public List<GameObject> go_ScoutList;
    private GameObject scoutContainer;

    public List<GameObject> go_RangerList;
    private GameObject rangerContainer;

    public List<GameObject> go_CorsairList;
    private GameObject corsairContainer;

    public List<GameObject> go_DestroyerList;
    private GameObject destroyerContainer;


    void Start ()
    {
        cl_GameManager = this;

        mainStationInst.GetComponent<MainStation>();
        

        FindObjectOfType<AudioManager>().Play("mainTheme");


        //MissleSeeker list
        go_missleSeekerList = new List<GameObject>();
        missleSeekerContainer = GameObject.Find("MissleSeekerContainer");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(missleSeekerInst);
            temp.SetActive(false);
            go_missleSeekerList.Add(temp);
            go_missleSeekerList[i].transform.parent = missleSeekerContainer.transform;
            go_missleSeekerList[i].name = "missleSeeker";
        }

        //Harvester List
        go_HarvesterList = new List<GameObject>();
        harvesterContainer = GameObject.Find("HarvesterList");
        for (int i = 0; i < 4; i++)
        {
            GameObject temp = Instantiate(harvesterInst);
            temp.SetActive(false);
            go_HarvesterList.Add(temp);
            go_HarvesterList[i].transform.parent = harvesterContainer.transform;
            go_HarvesterList[i].name = "harvester";
            if (i == 0) { go_HarvesterList[i].name = "harvester" + "1"; }
            if (i == 1) { go_HarvesterList[i].name = "harvester" + "2"; }
            if (i == 2) { go_HarvesterList[i].name = "harvester" + "3"; }
            if (i == 3) { go_HarvesterList[i].name = "harvester" + "4"; }
        }

        //Scouts List
        go_ScoutList = new List<GameObject>();
        scoutContainer = GameObject.Find("ScoutContainer");
        for (int i = 0; i < 4; i++)
        {
            GameObject temp = Instantiate(scoutInst);
            temp.SetActive(false);
            go_ScoutList.Add(temp);
            go_ScoutList[i].transform.parent = scoutContainer.transform;
            if (i == 0) { go_ScoutList[i].name = "scout" + "1"; go_ScoutList[i].GetComponentInChildren<ScoutsColliders>().name = "scout" + "1"; }
            if (i == 1) { go_ScoutList[i].name = "scout" + "2"; go_ScoutList[i].GetComponentInChildren<ScoutsColliders>().name = "scout" + "2"; }
            if (i == 2) { go_ScoutList[i].name = "scout" + "3"; go_ScoutList[i].GetComponentInChildren<ScoutsColliders>().name = "scout" + "3"; }
            if (i == 3) { go_ScoutList[i].name = "scout" + "4"; go_ScoutList[i].GetComponentInChildren<ScoutsColliders>().name = "scout" + "4"; }
        }

        //Rangers List
        go_RangerList = new List<GameObject>();
        rangerContainer = GameObject.Find("RangerContainer");
        for (int i = 0; i < 3; i++)
        {
            GameObject temp = Instantiate(rangerInst);
            temp.SetActive(false);
            go_RangerList.Add(temp);
            go_RangerList[i].transform.parent = rangerContainer.transform;
            if (i == 0) { go_RangerList[i].name = "ranger" + "1"; go_RangerList[i].GetComponentInChildren<RangersColliders>().name = "ranger" + "1"; }
            if (i == 1) { go_RangerList[i].name = "ranger" + "2"; go_RangerList[i].GetComponentInChildren<RangersColliders>().name = "ranger" + "2"; }
            if (i == 2) { go_RangerList[i].name = "ranger" + "3"; go_RangerList[i].GetComponentInChildren<RangersColliders>().name = "ranger" + "3"; }
        }

        //Corsair List
        go_CorsairList = new List<GameObject>();
        corsairContainer = GameObject.Find("CorsairContainer");
        for (int i = 0; i < 2; i++)
        {
            GameObject temp = Instantiate(corsairInst);
            temp.SetActive(false);
            go_CorsairList.Add(temp);
            go_CorsairList[i].transform.parent = corsairContainer.transform;
            if (i == 0) { go_CorsairList[i].name = "corsair" + "1"; }
            if (i == 1) { go_CorsairList[i].name = "corsair" + "2"; ; }
        }

        //Destroyer List
        go_DestroyerList = new List<GameObject>();
        destroyerContainer = GameObject.Find("DestroyerContainer");
        for (int i = 0; i < 1; i++)
        {
            GameObject temp = Instantiate(destroyerInst);
            temp.SetActive(false);
            go_DestroyerList.Add(temp);
            go_DestroyerList[i].transform.parent = destroyerContainer.transform;
            go_DestroyerList[i].name = "destroyer";
        }


    }


    //Set Harvester active from list
    public GameObject Harvester()
    {
        for (int i = 0; i < 4; i++)
        {
            if (!go_HarvesterList[i].activeInHierarchy)
            {
                go_HarvesterList[i].SetActive(true);
                return go_HarvesterList[i];
            }

        }

        GameObject temp = Instantiate(harvesterInst);
        go_HarvesterList.Add(temp);
        temp.SetActive(true);

        return temp;

    }

    // Function for UI
    public void CallHarvester()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 5)
        {
            Harvester();
            MainStation.cl_MainStation.HarvesterPrice();
        }

    }




    //Set Scout active from list
    public GameObject Scout() 
    {
        for (int i = 0; i < 4; i++)
        {
            if (!go_ScoutList[i].activeInHierarchy)
            {
                go_ScoutList[i].SetActive(true);
                return go_ScoutList[i];
            }

           }

        GameObject temp = Instantiate(scoutInst);
        go_ScoutList.Add(temp);
        temp.SetActive(true);
        
        return temp;
        
    }

    // Function for UI
    public void CallScout()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 15)
        {
            Scout();
            MainStation.cl_MainStation.ScoutPrice();
        }

    }
    //Set Ranger active from list
    public GameObject Ranger()
    {
        for (int i = 0; i < 3; i++)
        {
            if (!go_RangerList[i].activeInHierarchy)
            {
                go_RangerList[i].SetActive(true);
                return go_RangerList[i];
            }
        }

        GameObject temp = Instantiate(rangerInst);
        go_RangerList.Add(temp);
        temp.SetActive(true);
        return temp;
    }


    // function for UI
    public void CallRanger()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 25)
        {
            Ranger();
            MainStation.cl_MainStation.RangerPrice();
        }
    }

    //Set Corsair active from list
    public GameObject Corsair()
    {
        for (int i = 0; i < 10; i++)
        {
            if (!go_CorsairList[i].activeInHierarchy)
            {
                go_CorsairList[i].SetActive(true);
                return go_CorsairList[i];
            }
        }

        GameObject temp = Instantiate(corsairInst);
        go_CorsairList.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    // function for UI
    public void CallCorsair()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 35)
        {
            Corsair();
            MainStation.cl_MainStation.CorsairPrice();
        }
    }

    //Set Ranger Active from list
    public GameObject Destroyer()
    {
        for (int i = 0; i < 10; i++)
        {
            if (!go_DestroyerList[i].activeInHierarchy)
            {
                go_DestroyerList[i].SetActive(true);
                return go_DestroyerList[i];
            }
        }

        GameObject temp = Instantiate(destroyerInst);
        go_DestroyerList.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    // function for UI
    public void CallDestroyer()
    {

        if (MainStation.cl_MainStation.f_mainStationEnergy >= 45)
        {
            Destroyer();
            MainStation.cl_MainStation.DestroyerPrice();
        }
    }


    public void RepairBase()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 50)
        {
            MainStation.cl_MainStation.RepairPrice();
        }
    }

    public void UpgradeBase()
    {
        if (MainStation.cl_MainStation.f_mainStationEnergy >= 100)
        {
            MainStation.cl_MainStation.UpgradePrice();
        }
    }






    private void Update()
    {
        //Debug.Log(go_HarvesterList.Count);


    }

    private void FixedUpdate()
    {

    }




}
