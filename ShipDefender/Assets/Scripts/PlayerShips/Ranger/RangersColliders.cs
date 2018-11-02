using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangersColliders : MonoBehaviour {

    private void Start()
    {
        Debug.Log(this.gameObject.name);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Collision with UFO for R1,R2,R3
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger1")

        {
            Debug.Log("FIRST RANGER SHOTS");
            Ranger.cl_Ranger.b_IsAimed_Ranger1 = true; // for shoting
            Ranger.cl_Ranger.b_IsLaunched_Ranger1 = true; // for moving

            Ranger.cl_Ranger.Ranger1LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger1LaunchMissleGun2();

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger2")

        {
            Debug.Log("SECOND RANGER SHOTS");
            Ranger.cl_Ranger.b_IsAimed_Ranger2 = true; // for shoting
            Ranger.cl_Ranger.b_IsLaunched_Ranger2 = true; // for moving

            Ranger.cl_Ranger.Ranger2LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger2LaunchMissleGun2();

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger3")

        {
            Debug.Log("THIRD RANGER SHOTS");
            Ranger.cl_Ranger.b_IsAimed_Ranger3 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger3 = true;

            Ranger.cl_Ranger.Ranger3LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger3LaunchMissleGun2();

        }


        // Collision with ASTERIOD for R1,R2,R3
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger1")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger1 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger1 = true;

            Ranger.cl_Ranger.Ranger1LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger1LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger2")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger2 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger2 = true;

            Ranger.cl_Ranger.Ranger2LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger2LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger3")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger3 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger3 = true;

            Ranger.cl_Ranger.Ranger3LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger3LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();


        }


        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger1")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger1 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger1 = true;

            Ranger.cl_Ranger.Ranger1LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger1LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger2")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger2 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger2 = true;

            Ranger.cl_Ranger.Ranger2LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger2LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger3")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger3 = true;
            Ranger.cl_Ranger.b_IsLaunched_Ranger3 = true;

            Ranger.cl_Ranger.Ranger3LaunchMissleGun1();
            Ranger.cl_Ranger.Ranger3LaunchMissleGun2();
            //Ranger.cl_Ranger.MissleLaunchGun();



        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        //Colisions exit with UFO
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger1")

        {
            Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger2")

        {


            Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "ranger2")

        {

            Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;
        }




        //Collisions exit with asteroid 1
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger1")

        {



            Ranger.cl_Ranger.b_IsAimed_Ranger1 = false;

        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger2")

        {



            Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;

        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "ranger3")

        {


            Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;

        }



        //Colisions exit with asteriod 2
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger1")

        {


            Ranger.cl_Ranger.b_IsLaunched_Ranger1 = false;


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger2")

        {



            Ranger.cl_Ranger.b_IsAimed_Ranger2 = false;

        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "ranger3")

        {


            Ranger.cl_Ranger.b_IsAimed_Ranger3 = false;

        }

    }

}
