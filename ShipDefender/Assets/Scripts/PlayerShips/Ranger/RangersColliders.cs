using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangersColliders : MonoBehaviour {

    private void Start()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ranger tempRenger = gameObject.transform.parent.GetComponent<Ranger>();
        // Collision with UFO for R1,R2,R3
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "ranger1") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "ranger1") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "ranger1"))

        {
            Debug.Log("FIRST RANGER SHOTS");


            tempRenger.b_IsAimed_Ranger1 = true; // for shoting
            tempRenger.b_IsLaunched_Ranger1 = true; // for moving


            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun2();

            //tempRenger.Ranger1LaunchMissleGun1();
            //tempRenger.Ranger1LaunchMissleGun2();


        }
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "ranger2") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "ranger2") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "ranger2"))

        {
            Debug.Log("SECOND RANGER SHOTS");

        

            tempRenger.b_IsAimed_Ranger2 = true; // for shoting
            tempRenger.b_IsLaunched_Ranger2 = true; // for moving

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun2();

            // tempRenger.Ranger2LaunchMissleGun1();
            // tempRenger.Ranger2LaunchMissleGun2(); 

        }
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "ranger3") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "ranger3") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "ranger3"))

        {
            Debug.Log("THIRD RANGER SHOTS");
            tempRenger.b_IsAimed_Ranger3 = true;
            tempRenger.b_IsLaunched_Ranger3 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);


            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun2();

            //tempRenger.Ranger3LaunchMissleGun1();
            //tempRenger.Ranger3LaunchMissleGun2();

        }


        // Collision with ASTERIOD for R1,R2,R3
        if ((collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger1"))

        {
            tempRenger.b_IsAimed_Ranger1 = true;
            tempRenger.b_IsLaunched_Ranger1 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun2();

            //tempRenger.Ranger1LaunchMissleGun1();
            //tempRenger.Ranger1LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger2")

        {
            tempRenger.b_IsAimed_Ranger2 = true;
            tempRenger.b_IsLaunched_Ranger2 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun2();

            //tempRenger.Ranger2LaunchMissleGun1();
            //tempRenger.Ranger2LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger3")

        {
            tempRenger.b_IsAimed_Ranger3 = true;
            tempRenger.b_IsLaunched_Ranger3 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun2();

            //tempRenger.Ranger3LaunchMissleGun1();
            //tempRenger.Ranger3LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();


        }


        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger1")

        {
            tempRenger.b_IsAimed_Ranger1 = true;
            tempRenger.b_IsLaunched_Ranger1 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger1LaunchMissleGun2();

            //tempRenger.Ranger1LaunchMissleGun1();
            //tempRenger.Ranger1LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger2")

        {
            tempRenger.b_IsAimed_Ranger2 = true;
            tempRenger.b_IsLaunched_Ranger2 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger2LaunchMissleGun2();

            //tempRenger.Ranger2LaunchMissleGun1();
            //tempRenger.Ranger2LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger3")

        {
            tempRenger.b_IsAimed_Ranger3 = true;
            tempRenger.b_IsLaunched_Ranger3 = true;

            tempRenger.go_flame1.SetActive(false);
            tempRenger.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun1();
            ObjPoolManager.cl_ObjPoolManager.Ranger3LaunchMissleGun2();

            //tempRenger.Ranger3LaunchMissleGun1();
            //tempRenger.Ranger3LaunchMissleGun2();
            //tempRenger.MissleLaunchGun();



        }
    }

 

}
