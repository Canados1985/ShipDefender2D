using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo1Sensor : MonoBehaviour {

    
    public bool b_ColliderIsMainstation = false;
    public bool b_colliderIsHarvester = false;
    public bool b_colliderIsScout = false;
    public bool b_colliderIsRanger = false;
    public bool b_colliderIsCorsair = false;
    public bool b_colliderIsDestroyer = false;


    float f_counter = 3;

    void Start () {
       
	}

    private void OnTriggerStay2D(Collider2D collision)
    {

        
        ufo tempUFO = gameObject.transform.parent.GetComponent<ufo>();

        if (tempUFO.gameObject.name == "ufo1(Clone)")
        {


            if (collision.gameObject.name == "corsair1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair1 = true;
                tempUFO.target9Corsair1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "corsair2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair2 = true;
                tempUFO.target10Corsair2Transform.position = collision.transform.position;
            }


            if (collision.gameObject.name == "ranger1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.target2Ranger1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "ranger2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.target3Ranger2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "ranger3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.target4Ranger3Transform.position = collision.transform.position;
            }

            if (collision.gameObject.name == "scout1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target5Scout1Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.target6Scout2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.target7Scout3Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout4" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target8Scout4Transform.position = collision.transform.position;
            }




        }


        if (tempUFO.gameObject.name == "ufo2(Clone)")
        {
            if (collision.gameObject.name == "corsair1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair1 = true;
                tempUFO.target9Corsair1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "corsair2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair2 = true;
                tempUFO.target10Corsair2Transform.position = collision.transform.position;
            }


            if (collision.gameObject.name == "ranger1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.target2Ranger1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "ranger2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.target3Ranger2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "ranger3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.target4Ranger3Transform.position = collision.transform.position;
            }

            if (collision.gameObject.name == "scout1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target5Scout1Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.target6Scout2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.target7Scout3Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout4" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target8Scout4Transform.position = collision.transform.position;
            }

        }


        if (tempUFO.gameObject.name == "ufo3(Clone)")
        {

            if (collision.gameObject.name == "corsair1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair1 = true;
                tempUFO.target9Corsair1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "corsair2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsRanger == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingCorsair2 = true;
                tempUFO.target10Corsair2Transform.position = collision.transform.position;
            }


            if (collision.gameObject.name == "ranger1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger1 = true;
                tempUFO.target2Ranger1Transform.position = collision.transform.position;

            }
            if (collision.gameObject.name == "ranger2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger2 = true;
                tempUFO.target3Ranger2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "ranger3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsScout == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsRanger = true;
                tempUFO.b_IsFollowingRanger3 = true;
                tempUFO.target4Ranger3Transform.position = collision.transform.position;
            }

            if (collision.gameObject.name == "scout1" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target5Scout1Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout2" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout2 = true;
                tempUFO.target6Scout2Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout3" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout3 = true;
                tempUFO.target7Scout3Transform.position = collision.transform.position;
            }
            if (collision.gameObject.name == "scout4" && b_ColliderIsMainstation == false && b_colliderIsHarvester == false && b_colliderIsRanger == false && b_colliderIsCorsair == false && b_colliderIsDestroyer == false)
            {
                b_colliderIsScout = true;
                tempUFO.b_IsFollowingScout1 = true;
                tempUFO.target8Scout4Transform.position = collision.transform.position;
            }

        }













    }




    void Update () {
        ufo tempUFO = gameObject.transform.parent.GetComponent<ufo>();

            if (b_ColliderIsMainstation == true || b_colliderIsHarvester == true || b_colliderIsScout == true || b_colliderIsRanger == true || b_colliderIsCorsair == true || b_colliderIsDestroyer == true)

            {
                    f_counter -= Time.deltaTime;
            }

        if (f_counter <= 0)
        {
            
            
            if (tempUFO.gameObject.name == "ufo1(Clone)")
            {
                b_ColliderIsMainstation = false;
                b_colliderIsHarvester = false;
                b_colliderIsScout = false;
                b_colliderIsRanger = false;
                b_colliderIsCorsair = false;
                b_colliderIsDestroyer = false;
                b_ColliderIsMainstation = false;

                tempUFO.b_IsFollowingRanger1 = false;
                tempUFO.b_IsFollowingRanger2 = false;
                tempUFO.b_IsFollowingRanger3 = false;
                tempUFO.b_IsFollowingScout1 = false;
                tempUFO.b_IsFollowingScout2 = false;
                tempUFO.b_IsFollowingScout3 = false;
                tempUFO.b_IsFollowingScout4 = false;
                tempUFO.b_IsFollowingCorsair1 = false;
                tempUFO.b_IsFollowingCorsair2 = false;

                tempUFO.b_UFO1IsAttacking = false;
                tempUFO.go_gunFireUFO1.SetActive(false);
                tempUFO.go_engineFireUFO1.SetActive(true);
                f_counter = 3;

            }
            if (tempUFO.gameObject.name == "ufo2(Clone)")
            {
                b_ColliderIsMainstation = false;
                b_colliderIsHarvester = false;
                b_colliderIsScout = false;
                b_colliderIsRanger = false;
                b_colliderIsCorsair = false;
                b_colliderIsDestroyer = false;
                b_ColliderIsMainstation = false;

                tempUFO.b_IsFollowingRanger1 = false;
                tempUFO.b_IsFollowingRanger2 = false;
                tempUFO.b_IsFollowingRanger3 = false;
                tempUFO.b_IsFollowingScout1 = false;
                tempUFO.b_IsFollowingScout2 = false;
                tempUFO.b_IsFollowingScout3 = false;
                tempUFO.b_IsFollowingScout4 = false;
                tempUFO.b_IsFollowingCorsair1 = false;
                tempUFO.b_IsFollowingCorsair2 = false;

                tempUFO.b_UFO2IsAttacking = false;
                tempUFO.go_gunFireUFO2.SetActive(false);
                tempUFO.go_engineFireUFO2.SetActive(true);
                f_counter = 3;

            }
            if (tempUFO.gameObject.name == "ufo3(Clone)")
            {
                b_ColliderIsMainstation = false;
                b_colliderIsHarvester = false;
                b_colliderIsScout = false;
                b_colliderIsRanger = false;
                b_colliderIsCorsair = false;
                b_colliderIsDestroyer = false;
                b_ColliderIsMainstation = false;

                tempUFO.b_IsFollowingRanger1 = false;
                tempUFO.b_IsFollowingRanger2 = false;
                tempUFO.b_IsFollowingRanger3 = false;
                tempUFO.b_IsFollowingScout1 = false;
                tempUFO.b_IsFollowingScout2 = false;
                tempUFO.b_IsFollowingScout3 = false;
                tempUFO.b_IsFollowingScout4 = false;
                tempUFO.b_IsFollowingCorsair1 = false;
                tempUFO.b_IsFollowingCorsair2 = false;

                tempUFO.b_UFO3IsAttacking = false;
                tempUFO.go_gunFireUFO3.SetActive(false);
                tempUFO.go_engineFireUFO3.SetActive(true);
                f_counter = 3;

            }


        }


	}
}
