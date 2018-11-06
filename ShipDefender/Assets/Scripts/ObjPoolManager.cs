using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoolManager : MonoBehaviour {

    public static ObjPoolManager cl_ObjPoolManager;

    public GameObject go_ObjPoolManager;
    public Transform ObjPoolManagerTransform;


    //Bullet list for Scouts
    public GameObject bulletRef;

    public bool b_ScoutIsAttacking = false;

    public List<GameObject> go_bulletListS1Gun1;
    private GameObject bulletContainerS1Gun1;
    public List<GameObject> go_bulletListS1Gun2;
    private GameObject bulletContainerS1Gun2;

    public List<GameObject> go_bulletListS2Gun1;
    private GameObject bulletContainerS2Gun1;
    public List<GameObject> go_bulletListS2Gun2;
    private GameObject bulletContainerS2Gun2;

    public List<GameObject> go_bulletListS3Gun1;
    private GameObject bulletContainerS3Gun1;
    public List<GameObject> go_bulletListS3Gun2;
    private GameObject bulletContainerS3Gun2;

    public List<GameObject> go_bulletListS4Gun1;
    private GameObject bulletContainerS4Gun1;
    public List<GameObject> go_bulletListS4Gun2;
    private GameObject bulletContainerS4Gun2;


    //Missle List for Rangers
    public GameObject missleRef;

    public bool b_RangerIsAttacking = false;

    public List<GameObject> go_missleListR1Gun1;
    private GameObject missleContainerR1Gun1;
    public List<GameObject> go_missleListR1Gun2;
    private GameObject missleContainerR1Gun2;

    public List<GameObject> go_missleListR2Gun1;
    private GameObject missleContainerR2Gun1;
    public List<GameObject> go_missleListR2Gun2;
    private GameObject missleContainerR2Gun2;

    public List<GameObject> go_missleListR3Gun1;
    private GameObject missleContainerR3Gun1;
    public List<GameObject> go_missleListR3Gun2;
    private GameObject missleContainerR3Gun2;

    //Missle List for Corsair
    public GameObject missleSeekerRef;

    public bool b_CorsairIsAttacking = false;


    public List<GameObject> go_missleSeekerListC1Gun1;
    private GameObject missleSeeekerContainerC1Gun1;
    public List<GameObject> go_missleSeekerListC1Gun2;
    private GameObject missleSeeekerContainerC1Gun2;

    public List<GameObject> go_missleSeekerListC2Gun1;
    private GameObject missleSeeekerContainerC2Gun1;
    public List<GameObject> go_missleSeekerListC2Gun2;
    private GameObject missleSeeekerContainerC2Gun2;


    //EnergyBullets List for UFO
    public GameObject laserRef;

    public List<GameObject> go_weaponListUFO1;
    private GameObject UFO1Gun;

    public List<GameObject> go_weaponListUFO2;
    private GameObject UFO2Gun;

    public List<GameObject> go_weaponListUFO3;
    private GameObject UFO3Gun;



    void Start () {

        cl_ObjPoolManager = this;

        // ----- SCOUTS ----- //

        //Bullets list for Scout1 Gun1
        go_bulletListS1Gun1 = new List<GameObject>();
        bulletContainerS1Gun1 = GameObject.Find("scout1Ammo/gun1");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS1Gun1.Add(temp);
            go_bulletListS1Gun1[i].transform.parent = bulletContainerS1Gun1.transform;
            go_bulletListS1Gun1[i].transform.position = bulletContainerS1Gun1.transform.position;
            go_bulletListS1Gun1[i].name = "bulletSC1";
        }
        //Bullets list for Scout1 Gun2
        go_bulletListS1Gun2 = new List<GameObject>();
        bulletContainerS1Gun2 = GameObject.Find("scout1Ammo/gun2");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS1Gun2.Add(temp);
            go_bulletListS1Gun2[i].transform.parent = bulletContainerS1Gun2.transform;
            go_bulletListS1Gun2[i].transform.position = bulletContainerS1Gun2.transform.position;
            go_bulletListS1Gun2[i].name = "bulletSC1";
        }


        //Bullets list for Scout2 Gun1
        go_bulletListS2Gun1 = new List<GameObject>();
        bulletContainerS2Gun1 = GameObject.Find("scout2Ammo/gun1");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS2Gun1.Add(temp);
            go_bulletListS2Gun1[i].transform.parent = bulletContainerS2Gun1.transform;
            go_bulletListS2Gun1[i].transform.position = bulletContainerS2Gun1.transform.position;
            go_bulletListS2Gun1[i].name = "bulletSC2";
        }
        //Bullets list for Scout2 Gun2
        go_bulletListS2Gun2 = new List<GameObject>();
        bulletContainerS2Gun2 = GameObject.Find("scout2Ammo/gun2");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS2Gun2.Add(temp);
            go_bulletListS2Gun2[i].transform.parent = bulletContainerS2Gun2.transform;
            go_bulletListS2Gun2[i].transform.position = bulletContainerS2Gun2.transform.position;
            go_bulletListS2Gun2[i].name = "bulletSC2";
        }

        //Bullets list for Scout3Gun1
        go_bulletListS3Gun1 = new List<GameObject>();
        bulletContainerS3Gun1 = GameObject.Find("scout3Ammo/gun1");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS3Gun1.Add(temp);
            go_bulletListS3Gun1[i].transform.parent = bulletContainerS3Gun1.transform;
            go_bulletListS3Gun1[i].transform.position = bulletContainerS3Gun1.transform.position;
            go_bulletListS3Gun1[i].name = "bulletSC3";
        }
        //Bullets list for Scout3 Gun2
        go_bulletListS3Gun2 = new List<GameObject>();
        bulletContainerS3Gun2 = GameObject.Find("scout3Ammo/gun2");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS3Gun2.Add(temp);
            go_bulletListS3Gun2[i].transform.parent = bulletContainerS3Gun2.transform;
            go_bulletListS3Gun2[i].transform.position = bulletContainerS3Gun2.transform.position;
            go_bulletListS3Gun2[i].name = "bulletSC3";
        }


        //Bullets list for Scout1 Gun1
        go_bulletListS4Gun1 = new List<GameObject>();
        bulletContainerS4Gun1 = GameObject.Find("scout4Ammo/gun1");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS4Gun1.Add(temp);
            go_bulletListS4Gun1[i].transform.parent = bulletContainerS4Gun1.transform;
            go_bulletListS4Gun1[i].transform.position = bulletContainerS4Gun1.transform.position;
            go_bulletListS4Gun1[i].name = "bulletSC4";
        }
        //Bullets list for Scout1 Gun2
        go_bulletListS4Gun2 = new List<GameObject>();
        bulletContainerS4Gun2 = GameObject.Find("scout4Ammo/gun2");
        for (int i = 0; i < 50; i++)
        {
            GameObject temp = Instantiate(bulletRef);
            temp.SetActive(false);
            go_bulletListS4Gun2.Add(temp);
            go_bulletListS4Gun2[i].transform.parent = bulletContainerS4Gun2.transform;
            go_bulletListS4Gun2[i].transform.position = bulletContainerS4Gun2.transform.position;
            go_bulletListS4Gun2[i].name = "bulletSC4";
        }




        // ----- RANGERS ----- //
        
        //Missle list Ranger 1 GUN1
        go_missleListR1Gun1 = new List<GameObject>();
        missleContainerR1Gun1 = GameObject.Find("ranger1Ammo/gun1");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR1Gun1.Add(temp);
            go_missleListR1Gun1[i].transform.parent = missleContainerR1Gun1.transform;
            go_missleListR1Gun1[i].transform.position = missleContainerR1Gun1.transform.position;

            go_missleListR1Gun1[i].name = "missleR1";
        }
        //Missle list Ranger 1 GUN2
        go_missleListR1Gun2 = new List<GameObject>();
        missleContainerR1Gun2 = GameObject.Find("ranger1Ammo/gun2");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR1Gun2.Add(temp);
            go_missleListR1Gun2[i].transform.parent = missleContainerR1Gun2.transform;
            go_missleListR1Gun2[i].transform.position = missleContainerR1Gun2.transform.position;
            go_missleListR1Gun2[i].name = "missleR1";
        }

        //Missle list Ranger 2 GUN1
        go_missleListR2Gun1 = new List<GameObject>();
        missleContainerR2Gun1 = GameObject.Find("ranger2Ammo/gun1");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR2Gun1.Add(temp);
            go_missleListR2Gun1[i].transform.parent = missleContainerR2Gun1.transform;
            go_missleListR2Gun1[i].transform.position = missleContainerR2Gun1.transform.position;
            go_missleListR2Gun1[i].name = "missleR2";
        }
        //Missle list Ranger 2 GUN2
        go_missleListR2Gun2 = new List<GameObject>();
        missleContainerR2Gun2 = GameObject.Find("ranger2Ammo/gun2");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR2Gun2.Add(temp);
            go_missleListR2Gun2[i].transform.parent = missleContainerR2Gun2.transform;
            go_missleListR2Gun2[i].transform.position = missleContainerR2Gun2.transform.position;
            go_missleListR2Gun2[i].name = "missleR2";
        }

        //Missle list Ranger 3 GUN1
        go_missleListR3Gun1 = new List<GameObject>();
        missleContainerR3Gun1 = GameObject.Find("ranger3Ammo/gun1");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR3Gun1.Add(temp);
            go_missleListR3Gun1[i].transform.parent = missleContainerR3Gun1.transform;
            go_missleListR3Gun1[i].transform.position = missleContainerR3Gun1.transform.position;
            go_missleListR3Gun1[i].name = "missleR3";
        }
        go_missleListR3Gun2 = new List<GameObject>();
        missleContainerR3Gun2 = GameObject.Find("ranger3Ammo/gun2");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleRef);
            temp.SetActive(false);
            go_missleListR3Gun2.Add(temp);
            go_missleListR3Gun2[i].transform.parent = missleContainerR3Gun2.transform;
            go_missleListR3Gun2[i].transform.position = missleContainerR3Gun2.transform.position;
            go_missleListR3Gun2[i].name = "missleR3";
        }




        // ----- CORSAIRS ----- //


        //MissleSeeker list for Corsair1 GUN1
        go_missleSeekerListC1Gun1 = new List<GameObject>();
        missleSeeekerContainerC1Gun1 = GameObject.Find("corsair1Ammo/gun1");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleSeekerRef);
            temp.SetActive(false);
            go_missleSeekerListC1Gun1.Add(temp);
            go_missleSeekerListC1Gun1[i].transform.parent = missleSeeekerContainerC1Gun1.transform;
            go_missleSeekerListC1Gun1[i].name = "missleSeekerC1";
        }
        //MissleSeeker list for Corsair1 GUN2
        go_missleSeekerListC1Gun2 = new List<GameObject>();
        missleSeeekerContainerC1Gun2 = GameObject.Find("corsair1Ammo/gun2");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleSeekerRef);
            temp.SetActive(false);
            go_missleSeekerListC1Gun2.Add(temp);
            go_missleSeekerListC1Gun2[i].transform.parent = missleSeeekerContainerC1Gun2.transform;
            go_missleSeekerListC1Gun2[i].name = "missleSeekerC1";
        }

        //MissleSeeker list for Corsair2 GUN1
        go_missleSeekerListC2Gun1 = new List<GameObject>();
        missleSeeekerContainerC2Gun1 = GameObject.Find("corsair2Ammo/gun1");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleSeekerRef);
            temp.SetActive(false);
            go_missleSeekerListC2Gun1.Add(temp);
            go_missleSeekerListC2Gun1[i].transform.parent = missleSeeekerContainerC2Gun1.transform;
            go_missleSeekerListC2Gun1[i].name = "missleSeekerC2";
        }
        //MissleSeeker list for Corsair2 GUN2
        go_missleSeekerListC2Gun2 = new List<GameObject>();
        missleSeeekerContainerC2Gun2 = GameObject.Find("corsair2Ammo/gun2");
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(missleSeekerRef);
            temp.SetActive(false);
            go_missleSeekerListC2Gun2.Add(temp);
            go_missleSeekerListC2Gun2[i].transform.parent = missleSeeekerContainerC2Gun2.transform;
            go_missleSeekerListC2Gun2[i].name = "missleSeekerC2";
        }



        // ----- UFO ----- //


        //For UFO1
        go_weaponListUFO1 = new List<GameObject>();
        UFO1Gun = GameObject.Find("ufo1Ammo/gun");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(laserRef);
            temp.SetActive(false);
            go_weaponListUFO1.Add(temp);
            go_weaponListUFO1[i].transform.parent = UFO1Gun.transform;
            go_weaponListUFO1[i].transform.position = UFO1Gun.transform.position;
            go_weaponListUFO1[i].transform.rotation = UFO1Gun.transform.rotation;
            go_weaponListUFO1[i].name = "laserUFO1";
        }

        //Load Weapon For UFO2
        go_weaponListUFO2 = new List<GameObject>();
        UFO2Gun = GameObject.Find("ufo2Ammo/gun");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(laserRef);
            temp.SetActive(false);
            go_weaponListUFO2.Add(temp);
            go_weaponListUFO2[i].transform.parent = UFO2Gun.transform;
            go_weaponListUFO2[i].transform.position = UFO2Gun.transform.position;
            go_weaponListUFO2[i].transform.rotation = UFO2Gun.transform.rotation;
            go_weaponListUFO2[i].name = "laserUFO2";
        }

        //Load Weapon For UFO3
        go_weaponListUFO3 = new List<GameObject>();
        UFO3Gun = GameObject.Find("ufo3Ammo/gun");
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(laserRef);
            temp.SetActive(false);
            go_weaponListUFO3.Add(temp);
            go_weaponListUFO3[i].transform.parent = UFO3Gun.transform;
            go_weaponListUFO3[i].transform.position = UFO3Gun.transform.position;
            go_weaponListUFO3[i].transform.rotation = UFO3Gun.transform.rotation;
            go_weaponListUFO3[i].name = "laserUFO3";
        }
    }




    // ---- POOL BULLETS FOR SCOUTS ---- //

    //Set fire for Scout1 Gun1
    public GameObject FireS1G1()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout1/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS1Gun1[i].activeSelf)
            {
                go_bulletListS1Gun1[i].transform.position = tempTransform.transform.position;
                go_bulletListS1Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS1Gun1[i].SetActive(true);
                return go_bulletListS1Gun1[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS1Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set fire for Scout1 Gun2
    public GameObject FireS1G2()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout1/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS1Gun2[i].activeSelf)
            {
                go_bulletListS1Gun2[i].transform.position = tempTransform.transform.position;
                go_bulletListS1Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS1Gun2[i].SetActive(true);
                return go_bulletListS1Gun2[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS1Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout2 Gun1
    public GameObject FireS2G1()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout2/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS2Gun1[i].activeSelf)
            {
                go_bulletListS2Gun1[i].transform.position = tempTransform.transform.position;
                go_bulletListS2Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS2Gun1[i].SetActive(true);
                return go_bulletListS2Gun1[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS2Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set fire for Scout2 Gun2
    public GameObject FireS2G2()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout2/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS2Gun2[i].activeSelf)
            {
                go_bulletListS2Gun2[i].transform.position = tempTransform.transform.position;
                go_bulletListS2Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS2Gun2[i].SetActive(true);
                return go_bulletListS2Gun2[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS2Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout3 Gun1
    public GameObject FireS3G1()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout3/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS3Gun1[i].activeSelf)
            {
                go_bulletListS3Gun1[i].transform.position = tempTransform.transform.position;
                go_bulletListS3Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS3Gun1[i].SetActive(true);
                return go_bulletListS3Gun1[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS3Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set fire for Scout3 Gun2
    public GameObject FireS3G2()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout3/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS3Gun2[i].activeSelf)
            {
                go_bulletListS3Gun2[i].transform.position = tempTransform.transform.position;
                go_bulletListS3Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS3Gun2[i].SetActive(true);
                return go_bulletListS3Gun2[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS3Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout4 Gun1
    public GameObject FireS4G1()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout4/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS4Gun1[i].activeSelf)
            {
                go_bulletListS4Gun1[i].transform.position = tempTransform.transform.position;
                go_bulletListS4Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS4Gun1[i].SetActive(true);
                return go_bulletListS4Gun1[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS4Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set fire for Scout4 Gun2
    public GameObject FireS4G2()
    {
        GameObject go_temp = GameObject.Find("ScoutContainer/scout4/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();

        for (int i = 0; i < 50; i++)
        {
            if (!go_bulletListS4Gun2[i].activeSelf)
            {
                go_bulletListS4Gun2[i].transform.position = tempTransform.transform.position;
                go_bulletListS4Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_bulletListS4Gun2[i].SetActive(true);
                return go_bulletListS4Gun2[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS4Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }




    // ---- POOL MISSLES FOR RANGERS ---- //

    //Set Missle1 Active for Ranger1 Gun1
    public GameObject Ranger1LaunchMissleGun1()
    {

        GameObject go_temp = GameObject.Find("RangerContainer/ranger1/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR1Gun1[i].activeSelf)
            {

                go_missleListR1Gun1[i].transform.position = tempTransform.transform.position;
                go_missleListR1Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR1Gun1[i].SetActive(true);
                return go_missleListR1Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR1Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle2 Active from Ranger1 Gun2
    public GameObject Ranger1LaunchMissleGun2()
    {
        GameObject go_temp = GameObject.Find("RangerContainer/ranger1/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();


        FindObjectOfType<AudioManager>().Play("launchMissle");

        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR1Gun2[i].activeSelf)
            {

                go_missleListR1Gun2[i].transform.position = tempTransform.transform.position;
                go_missleListR1Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR1Gun2[i].SetActive(true);
                return go_missleListR1Gun2[i];
            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR1Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set Missle1 Active for Ranger2 Gun1
    public GameObject Ranger2LaunchMissleGun1()
    {

        GameObject go_temp = GameObject.Find("RangerContainer/ranger2/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR2Gun1[i].activeSelf)
            {

                go_missleListR2Gun1[i].transform.position = tempTransform.transform.position;
                go_missleListR2Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR2Gun1[i].SetActive(true);
                return go_missleListR2Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR2Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle2 Active from Ranger2 Gun2
    public GameObject Ranger2LaunchMissleGun2()
    {
        GameObject go_temp = GameObject.Find("RangerContainer/ranger2/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();


        FindObjectOfType<AudioManager>().Play("launchMissle");

        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR2Gun2[i].activeSelf)
            {

                go_missleListR2Gun2[i].transform.position = tempTransform.transform.position;
                go_missleListR2Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR2Gun2[i].SetActive(true);
                return go_missleListR2Gun2[i];
            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR2Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set Missle1 Active for Ranger3 Gun1
    public GameObject Ranger3LaunchMissleGun1()
    {

        GameObject go_temp = GameObject.Find("RangerContainer/ranger3/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR3Gun1[i].activeSelf)
            {

                go_missleListR3Gun1[i].transform.position = tempTransform.transform.position;
                go_missleListR3Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR3Gun1[i].SetActive(true);
                return go_missleListR3Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleRef);
        go_missleListR3Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle2 Active from Ranger2 Gun2
    public GameObject Ranger3LaunchMissleGun2()
    {
        GameObject go_temp = GameObject.Find("RangerContainer/ranger3/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();


        FindObjectOfType<AudioManager>().Play("launchMissle");

        for (int i = 0; i < 6; i++)
        {
            if (!go_missleListR3Gun2[i].activeSelf)
            {

                go_missleListR3Gun2[i].transform.position = tempTransform.transform.position;
                go_missleListR3Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_missleListR3Gun2[i].SetActive(true);
                return go_missleListR3Gun2[i];
            }
        }

        GameObject temp = Instantiate(missleRef);
        go_missleListR3Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }




    // ---- POOL MISSLESSEEKERS FOR CORSAIRS ---- //


    //Set Missle1 Active for Corsair1 Gun1
    public GameObject Corsair1LaunchMissleGun1()
    {

        GameObject go_temp = GameObject.Find("CorsairContainer/corsair1/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleSeekerListC1Gun1[i].activeSelf)
            {

                go_missleSeekerListC1Gun1[i].transform.position = tempTransform.transform.position;
                go_missleSeekerListC1Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_missleSeekerListC1Gun1[i].SetActive(true);
                return go_missleSeekerListC1Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleSeekerRef);
        go_missleSeekerListC1Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle1 Active for Corsair1 Gun2
    public GameObject Corsair1LaunchMissleGun2()
    {

        GameObject go_temp = GameObject.Find("CorsairContainer/corsair1/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleSeekerListC1Gun2[i].activeSelf)
            {

                go_missleSeekerListC1Gun2[i].transform.position = tempTransform.transform.position;
                go_missleSeekerListC1Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_missleSeekerListC1Gun2[i].SetActive(true);
                return go_missleSeekerListC1Gun2[i];
            }
        }
        GameObject temp = Instantiate(missleSeekerRef);
        go_missleSeekerListC1Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set Missle1 Active for Corsair2 Gun1
    public GameObject Corsair2LaunchMissleGun1()
    {

        GameObject go_temp = GameObject.Find("CorsairContainer/corsair2/gun1");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleSeekerListC2Gun1[i].activeSelf)
            {

                go_missleSeekerListC2Gun1[i].transform.position = tempTransform.transform.position;
                go_missleSeekerListC2Gun1[i].transform.rotation = tempTransform.transform.rotation;
                go_missleSeekerListC2Gun1[i].SetActive(true);
                return go_missleSeekerListC2Gun1[i];
            }
        }
        GameObject temp = Instantiate(missleSeekerRef);
        go_missleSeekerListC2Gun1.Add(temp);
        temp.SetActive(true);
        return temp;
    }
    //Set Missle1 Active for Corsair1 Gun2
    public GameObject Corsair2LaunchMissleGun2()
    {

        GameObject go_temp = GameObject.Find("CorsairContainer/corsair2/gun2");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        FindObjectOfType<AudioManager>().Play("launchMissle");


        for (int i = 0; i < 6; i++)
        {
            if (!go_missleSeekerListC2Gun2[i].activeSelf)
            {

                go_missleSeekerListC2Gun2[i].transform.position = tempTransform.transform.position;
                go_missleSeekerListC2Gun2[i].transform.rotation = tempTransform.transform.rotation;
                go_missleSeekerListC2Gun2[i].SetActive(true);
                return go_missleSeekerListC2Gun2[i];
            }
        }
        GameObject temp = Instantiate(missleSeekerRef);
        go_missleSeekerListC2Gun2.Add(temp);
        temp.SetActive(true);
        return temp;
    }


    // ---- POOL FOR UFO ---- //

    //UFO1 Fire
    public GameObject FireUFO1()
    {
        GameObject go_temp = GameObject.Find("ufo1(Clone)/gun");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        for (int i = 0; i < 10; i++)
        {
            if (!go_weaponListUFO1[i].activeSelf)
            {
                go_weaponListUFO1[i].transform.position = tempTransform.transform.position;
                go_weaponListUFO1[i].transform.rotation = tempTransform.transform.rotation;
                go_weaponListUFO1[i].SetActive(true);
                return go_weaponListUFO1[i];
            }
        }
        GameObject temp = Instantiate(laserRef);
        go_weaponListUFO1.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //UFO2 Fire
    public GameObject FireUFO2()
    {

        GameObject go_temp = GameObject.Find("ufo2(Clone)/gun");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        for (int i = 0; i < 10; i++)
        {
            if (!go_weaponListUFO2[i].activeSelf)
            {
                go_weaponListUFO2[i].transform.position = tempTransform.transform.position;
                go_weaponListUFO2[i].transform.rotation = tempTransform.transform.rotation;
                go_weaponListUFO2[i].SetActive(true);
                return go_weaponListUFO2[i];
            }
        }
        GameObject temp = Instantiate(laserRef);
        go_weaponListUFO2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //UFO3 Fire
    public GameObject FireUFO3()
    {
        GameObject go_temp = GameObject.Find("ufo3(Clone)/gun");
        Transform tempTransform = go_temp.GetComponent<Transform>();
        for (int i = 0; i < 10; i++)
        {
            if (!go_weaponListUFO3[i].activeSelf)
            {
                go_weaponListUFO3[i].transform.position = tempTransform.transform.position;
                go_weaponListUFO3[i].transform.rotation = tempTransform.transform.rotation;
                go_weaponListUFO3[i].SetActive(true);
                return go_weaponListUFO3[i];
            }
        }
        GameObject temp = Instantiate(laserRef);
        go_weaponListUFO3.Add(temp);
        temp.SetActive(true);
        return temp;
    }


    void Update () {
		

	}
}
