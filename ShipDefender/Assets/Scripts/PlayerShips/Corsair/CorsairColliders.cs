using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsairColliders : MonoBehaviour {



	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {


        Corsair tempCorsair = gameObject.transform.parent.GetComponent<Corsair>();

        // Collision with UFO for C1
        if (collision.gameObject.name == "ufo1(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1") 

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);



            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
            tempMissleSeeker.target1UFO1Transform.position = collision.gameObject.transform.position;
            temp2MissleSeeker.target1UFO1Transform.position = collision.gameObject.transform.position;

        }

        if (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();



            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);



            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
            tempMissleSeeker.target2UFO2Transform.position = collision.gameObject.transform.position;
            temp2MissleSeeker.target2UFO2Transform.position = collision.gameObject.transform.position;
        }


        if(collision.gameObject.name == "ufo3(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();



            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair1 = true;
            tempCorsair.go_flame1.SetActive(false);
            tempCorsair.go_flame2.SetActive(false);



            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();
            tempMissleSeeker.target3UFO3Transform.position = collision.gameObject.transform.position;
            temp2MissleSeeker.target3UFO3Transform.position = collision.gameObject.transform.position;
        }




        // Collision with UFO for C2


        if (collision.gameObject.name == "ufo1(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();



            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
            tempMissleSeeker.target1UFO1Transform.position = collision.transform.position;
            temp2MissleSeeker.target1UFO1Transform.position = collision.transform.position;

        }


        if (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();



            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
            tempMissleSeeker.target2UFO2Transform.position = collision.transform.position;
            temp2MissleSeeker.target2UFO2Transform.position = collision.transform.position;
        }

        if (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")
        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();



            tempMissleSeeker.b_pickTarger1UFO1 = true;
            temp2MissleSeeker.b_pickTarger1UFO1 = true;

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();
            tempMissleSeeker.target3UFO3Transform.position = collision.transform.position;
            temp2MissleSeeker.target3UFO3Transform.position = collision.transform.position;
        }












        // Collision with ASTERIOD for C1,C2
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();

            tempMissleSeeker.target4asteriod1Transform.position = collision.transform.position;
            temp2MissleSeeker.target4asteriod1Transform.position = collision.transform.position;


            tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            temp2MissleSeeker.b_pickTarger4Asteroid1 = true;


            tempCorsair.b_IsAimed_Corsair1 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();

            tempMissleSeeker.target4asteriod1Transform.position = collision.transform.position;
            temp2MissleSeeker.target4asteriod1Transform.position = collision.transform.position;

            tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            temp2MissleSeeker.b_pickTarger4Asteroid1 = true;


            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();


        }




        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair1")

        {
            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun1/missleSeekerC1").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair1Ammo/gun2/missleSeekerC1").GetComponent<MissleSeeker>();


            tempMissleSeeker.target5asteriod2Transform.position = collision.transform.position;
            temp2MissleSeeker.target5asteriod2Transform.position = collision.transform.position;

            tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            temp2MissleSeeker.b_pickTarger4Asteroid1 = true;


            tempCorsair.b_IsAimed_Corsair1 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair1LaunchMissleGun2();



        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.GetComponentInParent<Corsair>().gameObject.name == "corsair2")

        {

            MissleSeeker tempMissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun1/missleSeekerC2").GetComponent<MissleSeeker>();
            MissleSeeker temp2MissleSeeker = GameObject.Find("ObjPoolManager/corsair2Ammo/gun2/missleSeekerC2").GetComponent<MissleSeeker>();

            tempMissleSeeker.target5asteriod2Transform.position = collision.transform.position;
            temp2MissleSeeker.target5asteriod2Transform.position = collision.transform.position;

            tempMissleSeeker.b_pickTarger4Asteroid1 = true;
            temp2MissleSeeker.b_pickTarger4Asteroid1 = true;

            tempCorsair.b_IsAimed_Corsair2 = true; // for shoting

            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Corsair2LaunchMissleGun2();


        }

    }




}
