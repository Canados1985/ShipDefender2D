using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutsColliders : MonoBehaviour {

	
	void Start () {
		
	}



    private void OnTriggerStay2D(Collider2D collision)
    {
        // Collision with UFO for R1,R2,R3
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "scout1")

        {
            Debug.Log("SCOUT1 START COLL");
            Scout.cl_Scout.b_IsAimed_Scout1 = true; // for shoting
                                                   // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active

            Scout.cl_Scout.FireS1();

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "scout2")

        {

            Scout.cl_Scout.b_IsAimed_Scout2 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "scout3")

        {

            Scout.cl_Scout.b_IsAimed_Scout3 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();

        }
        if (collision.gameObject.tag == "UFO" && this.gameObject.name == "scout4")

        {

            Scout.cl_Scout.b_IsAimed_Scout4 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();

        }


        // Collision with ASTERIOD for R1,R2,R3
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout1")

        {
            Scout.cl_Scout.b_IsAimed_Scout1 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout2")

        {
            Scout.cl_Scout.b_IsAimed_Scout2 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout3")

        {
            Scout.cl_Scout.b_IsAimed_Scout3 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout4")

        {
            Scout.cl_Scout.b_IsAimed_Scout4 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }



        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout1")

        {
            Scout.cl_Scout.b_IsAimed_Scout1 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout2")

        {
            Scout.cl_Scout.b_IsAimed_Scout2 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout3")

        {
            Scout.cl_Scout.b_IsAimed_Scout3 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout4")

        {
            Scout.cl_Scout.b_IsAimed_Scout4 = true; // for shoting
                                                    // for movements
            Scout.cl_Scout.b_IsShoting = true;
            Scout.cl_Scout.gunSpriteInst.SetActive(true); // Gun Sprite Active
            Scout.cl_Scout.FireS1();


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

     

    }



}
