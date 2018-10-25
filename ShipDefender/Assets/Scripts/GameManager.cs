using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager cl_GameManager;

    public GameObject mainStationInst;

    public GameObject bulletInst;
    public GameObject missleInst;
    public GameObject missleSeekerInst;

    public GameObject scoutInst;
    public GameObject rangerInst;
    public GameObject corsairInst;
    public GameObject destroyerInst;

    public GameObject ufo1Inst;
    public GameObject ufo2Inst;
    public GameObject ufo3Inst;

    [HideInInspector]
    public List<GameObject> go_bulletList;
    private GameObject bulletContainer;

    public List<GameObject> go_missleList;
    private GameObject missleContainer;

    public List<GameObject> go_missleSeekerList;
    private GameObject missleSeekerContainer;

    public List<GameObject> go_UFObulletList;
    private GameObject UFObulletContainer;

    public List<GameObject> go_ScoutList;
    private GameObject scoutContainer;

    public List<GameObject> go_RangerList;
    private GameObject rangerContainer;

    public List<GameObject> go_CorsairList;
    private GameObject corsairContainer;

    public List<GameObject> go_DestroyerList;
    private GameObject destroyerContainer;

    public List<GameObject> go_UFO1_List;
    public List<GameObject> go_UFO2_List;
    public List<GameObject> go_UFO3_List;
    private GameObject enemyContainer;




    void Start ()
    {
        cl_GameManager = this;

        mainStationInst.GetComponent<MainStation>();

        //Bullets list
        go_bulletList = new List<GameObject>();
        bulletContainer = GameObject.Find("BulletContainer");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletInst);
            temp.SetActive(false);
            go_bulletList.Add(temp);
            go_bulletList[i].transform.parent = bulletContainer.transform;
            go_bulletList[i].name = "bullet";
        }

        //Missle list
        go_missleList = new List<GameObject>();
        missleContainer = GameObject.Find("MissleContainer");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(missleInst);
            temp.SetActive(false);
            go_missleList.Add(temp);
            go_missleList[i].transform.parent = missleContainer.transform;
            go_missleList[i].name = "missle";
        }

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

        //Scouts List
        go_ScoutList = new List<GameObject>();
        scoutContainer = GameObject.Find("ScoutContainer");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(scoutInst);
            temp.SetActive(false);
            go_ScoutList.Add(temp);
            go_ScoutList[i].transform.parent = scoutContainer.transform;
            go_ScoutList[i].name = "scout";
        }

        //Rangers List
        go_RangerList = new List<GameObject>();
        rangerContainer = GameObject.Find("RangerContainer");
        for (int i = 0; i < 8; i++)
        {
            GameObject temp = Instantiate(rangerInst);
            temp.SetActive(false);
            go_RangerList.Add(temp);
            go_RangerList[i].transform.parent = rangerContainer.transform;
            go_RangerList[i].name = "ranger";
        }

        //Corsair List
        go_CorsairList = new List<GameObject>();
        corsairContainer = GameObject.Find("CorsairContainer");
        for (int i = 0; i < 5; i++)
        {
            GameObject temp = Instantiate(corsairInst);
            temp.SetActive(false);
            go_CorsairList.Add(temp);
            go_CorsairList[i].transform.parent = corsairContainer.transform;
            go_CorsairList[i].name = "corsair";
        }

        //Destroyer List
        go_DestroyerList = new List<GameObject>();
        destroyerContainer = GameObject.Find("DestroyerContainer");
        for (int i = 0; i < 3; i++)
        {
            GameObject temp = Instantiate(destroyerInst);
            temp.SetActive(false);
            go_DestroyerList.Add(temp);
            go_DestroyerList[i].transform.parent = destroyerContainer.transform;
            go_DestroyerList[i].name = "destroyer";
        }

        //UFO1 List
        go_UFO1_List = new List<GameObject>();
        enemyContainer = GameObject.Find("EnemyContainer");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(ufo1Inst);
            temp.SetActive(false);
            go_UFO1_List.Add(temp);
            go_UFO1_List[i].transform.parent = enemyContainer.transform;
            go_UFO1_List[i].name = "UFO_1";
        }

        //UFO2 List
        go_UFO2_List = new List<GameObject>();
        enemyContainer = GameObject.Find("EnemyContainer");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(ufo2Inst);
            temp.SetActive(false);
            go_UFO2_List.Add(temp);
            go_UFO2_List[i].transform.parent = enemyContainer.transform;
            go_UFO2_List[i].name = "UFO_2";
        }
        //UFO3 List
        go_UFO3_List = new List<GameObject>();
        enemyContainer = GameObject.Find("EnemyContainer");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(ufo3Inst);
            temp.SetActive(false);
            go_UFO3_List.Add(temp);
            go_UFO3_List[i].transform.parent = enemyContainer.transform;
            go_UFO3_List[i].name = "UFO_3";
        }


    }

    //Set Scout active from list
    public GameObject Scout() 
    {
        for (int i = 0; i < 10; i++)
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
        for (int i = 0; i < 10; i++)
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



    //Set UFO1 active from list
    public GameObject callUFO1()
    {
        for (int i = 0; i < 10; i++)
        {
            if (!go_UFO1_List[i].activeInHierarchy)
            {
                go_UFO1_List[i].SetActive(true);
                return go_UFO1_List[i];
            }
        }

        GameObject temp = Instantiate(ufo1Inst);
        go_UFO1_List.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set UFO2 active from list
    public GameObject callUFO2()
    {
        for (int i = 0; i < 10; i++)
        {
            if (!go_UFO2_List[i].activeInHierarchy)
            {
                go_UFO2_List[i].SetActive(true);
                return go_UFO2_List[i];
            }
        }

        GameObject temp = Instantiate(ufo2Inst);
        go_UFO2_List.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set UFO2 active from list
    public GameObject callUFO3()
    {
        for (int i = 0; i < 10; i++)
        {
            if (!go_UFO3_List[i].activeInHierarchy)
            {
                go_UFO3_List[i].SetActive(true);
                return go_UFO3_List[i];
            }
        }

        GameObject temp = Instantiate(ufo3Inst);
        go_UFO3_List.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set Missle Active from list
    public GameObject LaunchMissle()
    {
        for (int i = 0; i < 50; i++)
        {
            if (!go_missleList[i].activeInHierarchy)
            {
                go_missleList[i].SetActive(true);
                return go_missleList[i];
            }
        }

        GameObject temp = Instantiate(missleInst);
        go_missleList.Add(temp);
        temp.SetActive(true);
        return temp;
    }



    private void Update()
    {



    }



    private void FixedUpdate()
    {

    }




}
