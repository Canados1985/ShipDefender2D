using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutsColliders : MonoBehaviour {

	
	void Start () {
		
	}



    private void OnTriggerStay2D(Collider2D collision)
    {

        Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();

        // Collision with UFO for S1,S2,S3,S4
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "scout1") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "scout1") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "scout1"))

        {
            tempScout.b_IsAimed_Scout1 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS1G1();
            ObjPoolManager.cl_ObjPoolManager.FireS1G2();
            tempScout.GunSound();


        }
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "scout2") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "scout2") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "scout2"))

        {

            tempScout.b_IsAimed_Scout2 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS2G1();
            ObjPoolManager.cl_ObjPoolManager.FireS2G2();
            tempScout.GunSound();



        }
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "scout3") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "scout3") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "scout3"))

        {

            tempScout.b_IsAimed_Scout3 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS3G1();
            ObjPoolManager.cl_ObjPoolManager.FireS3G2();
            tempScout.GunSound();


        }
        if ((collision.gameObject.name == "ufo1(Clone)" && this.gameObject.name == "scout4") || (collision.gameObject.name == "ufo2(Clone)" && this.gameObject.name == "scout4") || (collision.gameObject.name == "ufo3(Clone)" && this.gameObject.name == "scout4"))

        {

            tempScout.b_IsAimed_Scout4 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS4G1();
            ObjPoolManager.cl_ObjPoolManager.FireS4G2();
            tempScout.GunSound();


        }




        // Collision with ASTERIOD for S1,S2,S3,S4
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout1")

        {
            tempScout.b_IsAimed_Scout1 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS1G1();
            ObjPoolManager.cl_ObjPoolManager.FireS1G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout2")

        {
            tempScout.b_IsAimed_Scout2 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS2G1();
            ObjPoolManager.cl_ObjPoolManager.FireS2G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout3")

        {
            tempScout.b_IsAimed_Scout3 = true; // for shoting  

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS3G1();
            ObjPoolManager.cl_ObjPoolManager.FireS3G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID" && this.gameObject.name == "scout4")

        {
            tempScout.b_IsAimed_Scout4 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS4G1();
            ObjPoolManager.cl_ObjPoolManager.FireS4G2();
            tempScout.GunSound();



        }



        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout1")

        {
            tempScout.b_IsAimed_Scout1 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS1G1();
            ObjPoolManager.cl_ObjPoolManager.FireS1G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout2")

        {
            tempScout.b_IsAimed_Scout2 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS2G1();
            ObjPoolManager.cl_ObjPoolManager.FireS2G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout3")

        {
            tempScout.b_IsAimed_Scout3 = true; // for shoting  

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS3G1();
            ObjPoolManager.cl_ObjPoolManager.FireS3G2();
            tempScout.GunSound();



        }
        if (collision.gameObject.tag == "ASTEROID2" && this.gameObject.name == "scout4")

        {
            tempScout.b_IsAimed_Scout4 = true; // for shoting

            tempScout.go_gunFire1.SetActive(true);
            tempScout.go_gunFire2.SetActive(true);
            tempScout.go_flame1.SetActive(false);
            tempScout.go_flame2.SetActive(false);

            ObjPoolManager.cl_ObjPoolManager.FireS4G1();
            ObjPoolManager.cl_ObjPoolManager.FireS4G2();
            tempScout.GunSound();



        }
    }
    





    private void OnTriggerExit2D(Collider2D collision)
    {

     

    }



}
