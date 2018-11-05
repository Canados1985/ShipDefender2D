using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoGun : MonoBehaviour {

	
	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {

       ufo tempUFO = gameObject.transform.parent.GetComponent<ufo>();
        

        if (tempUFO.name == "ufo1(Clone)")
        {

            if (collision.gameObject.name == "scout2")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);

                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }
            if (collision.gameObject.name == "scout3")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }
            if (collision.gameObject.name == "scout4")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingScout4 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }

            if (collision.gameObject.name == "ranger1")
            {
                Debug.Log("UFO GUN WORKS");
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }
            if (collision.gameObject.name == "ranger2")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }
            if (collision.gameObject.name == "ranger3")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
            }
            if (collision.gameObject.name == "MainStationSprite")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO1.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
                MainStation.cl_MainStation.f_mainStationHealth = MainStation.cl_MainStation.f_mainStationHealth - 25;
            }

        }

        if (tempUFO.name == "ufo2(Clone)")
        {
            if (collision.gameObject.name == "scout1")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "scout2")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "scout3")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "scout4")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingScout4 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }

            if (collision.gameObject.name == "ranger1")
            {
                Debug.Log("UFO GUN WORKS");
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "ranger2")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "ranger3")
            {
                tempUFO.b_UFO2IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO2();
            }
            if (collision.gameObject.name == "MainStationSprite")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO2.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
                MainStation.cl_MainStation.f_mainStationHealth = MainStation.cl_MainStation.f_mainStationHealth - 25;
            }

        }

        if (tempUFO.name == "ufo3(Clone)")
        {
            if (collision.gameObject.name == "scout1")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "scout2")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "scout3")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "scout4")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingScout4 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }

            if (collision.gameObject.name == "ranger1")
            {
                Debug.Log("UFO GUN WORKS");
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "ranger2")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "ranger3")
            {
                tempUFO.b_UFO3IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO3();
            }
            if (collision.gameObject.name == "MainStationSprite")
            {
                tempUFO.b_UFO1IsAttacking = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.go_gunFireUFO3.SetActive(true);
                ObjPoolManager.cl_ObjPoolManager.FireUFO1();
                MainStation.cl_MainStation.f_mainStationHealth = MainStation.cl_MainStation.f_mainStationHealth - 25;
            }

        }



    }

}
