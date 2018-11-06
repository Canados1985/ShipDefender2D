using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsairColliders : MonoBehaviour {



	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {


        Corsair tempCorsair = gameObject.transform.parent.GetComponent<Corsair>();


        // Collision with UFO for Corsair 1
        if (collision.gameObject.name == "ufo1(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1" && tempCorsair.b_IsAimed_Corsair2 == false) 

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();

            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
                tempMissleSeeker.target1UFO1Transform.position = collision.gameObject.transform.position;
                tempMissleSeeker.b_pickTarger1UFO1 = true;
            }
            if (i_random > 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
                temp2MissleSeeker.target1UFO1Transform.position = collision.gameObject.transform.position;
                temp2MissleSeeker.b_pickTarger1UFO1 = true;
            }


        }

        if (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1" && tempCorsair.b_IsAimed_Corsair2 == false)

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
                tempMissleSeeker.target2UFO2Transform.position = collision.gameObject.transform.position;
                tempMissleSeeker.b_pickTarger2UFO2 = true;
            }
            if (i_random > 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
                temp2MissleSeeker.target2UFO2Transform.position = collision.gameObject.transform.position;
                temp2MissleSeeker.b_pickTarger2UFO2 = true;
            }
        }


        if(collision.gameObject.name == "ufo3(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1" && tempCorsair.b_IsAimed_Corsair2 == false)

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);


            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
                tempMissleSeeker.target3UFO3Transform.position = collision.gameObject.transform.position;
                tempMissleSeeker.b_pickTarger3UFO3 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
                temp2MissleSeeker.target3UFO3Transform.position = collision.gameObject.transform.position;
                temp2MissleSeeker.b_pickTarger3UFO3 = true;
            }
        }




        // Collision with UFO for Corsair 2

        if (collision.gameObject.name == "ufo1(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2" && tempCorsair.b_IsAimed_Corsair1 == false)

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
                tempMissleSeeker.target1UFO1Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger1UFO1 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
                temp2MissleSeeker.target1UFO1Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger1UFO1 = true;
            }

        }


        if (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2" && tempCorsair.b_IsAimed_Corsair1 == false)
        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
                tempMissleSeeker.target2UFO2Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger2UFO2 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
                temp2MissleSeeker.target2UFO2Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger2UFO2 = true;
            }
        }

        if (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2" && tempCorsair.b_IsAimed_Corsair1 == false)
        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
                tempMissleSeeker.target3UFO3Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger3UFO3 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
                temp2MissleSeeker.target3UFO3Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger3UFO3 = true;
            }
        }












        // Collision with ASTERIOD for C1,C2
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1" && tempCorsair.b_IsAimed_Corsair2 == false)

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();



            tempCorsair.b_IsAimed_Corsair1 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
                tempMissleSeeker.target4asteriod1Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
                temp2MissleSeeker.target4asteriod1Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger4Asteroid1 = true;
            }


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2" && tempCorsair.b_IsAimed_Corsair1 == false)

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
                tempMissleSeeker.target4asteriod1Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
                temp2MissleSeeker.target4asteriod1Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger4Asteroid1 = true;
            }



        }




        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1" && tempCorsair.b_IsAimed_Corsair2 == false)

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


            tempCorsair.b_IsAimed_Corsair1 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
                tempMissleSeeker.target5asteriod2Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger5Asteroid2 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
                temp2MissleSeeker.target5asteriod2Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger5Asteroid2 = true;
            }




        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2" && tempCorsair.b_IsAimed_Corsair1 == false)

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);

            int i_random;
            i_random = Random.Range(0, 10);

            if (i_random <= 5)
            {
                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
                tempMissleSeeker.target5asteriod2Transform.position = collision.transform.position;
                tempMissleSeeker.b_pickTarger5Asteroid2 = true;
            }
            if (i_random > 5)
            {

                ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
                temp2MissleSeeker.target5asteriod2Transform.position = collision.transform.position;
                temp2MissleSeeker.b_pickTarger5Asteroid2 = true;
            }


        }

    }




}
