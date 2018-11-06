using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSeekerSensor : MonoBehaviour {



	void Start () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        MissleSeeker tempMissleSeeker = gameObject.transform.parent.GetComponent<MissleSeeker>();


        if (collision.gameObject.name == "ufo1(Clone)" && tempMissleSeeker.b_pickTarger1UFO1 == false && tempMissleSeeker.b_pickTarger2UFO2 == false && tempMissleSeeker.b_pickTarger3UFO3 == false && tempMissleSeeker.b_pickTarger4Asteroid1 == false && tempMissleSeeker.b_pickTarger5Asteroid2 == false)
        {
            tempMissleSeeker.target1UFO1Transform.position = collision.gameObject.transform.position;
            tempMissleSeeker.b_pickTarger1UFO1 = true;
        }
        if (collision.gameObject.name == "ufo2(Clone)" && tempMissleSeeker.b_pickTarger1UFO1 == false && tempMissleSeeker.b_pickTarger2UFO2 == false && tempMissleSeeker.b_pickTarger3UFO3 == false && tempMissleSeeker.b_pickTarger4Asteroid1 == false && tempMissleSeeker.b_pickTarger5Asteroid2 == false)
        {
            tempMissleSeeker.target2UFO2Transform.position = collision.gameObject.transform.position;
            tempMissleSeeker.b_pickTarger2UFO2 = true;
        }
        if (collision.gameObject.name == "ufo3(Clone)" && tempMissleSeeker.b_pickTarger1UFO1 == false && tempMissleSeeker.b_pickTarger2UFO2 == false && tempMissleSeeker.b_pickTarger3UFO3 == false && tempMissleSeeker.b_pickTarger4Asteroid1 == false && tempMissleSeeker.b_pickTarger5Asteroid2 == false)
        {
            tempMissleSeeker.target3UFO3Transform.position = collision.gameObject.transform.position;
            tempMissleSeeker.b_pickTarger3UFO3 = true;
        }
        if (collision.gameObject.tag == "ASTEROID" && tempMissleSeeker.b_pickTarger1UFO1 == false && tempMissleSeeker.b_pickTarger2UFO2 == false && tempMissleSeeker.b_pickTarger3UFO3 == false && tempMissleSeeker.b_pickTarger4Asteroid1 == false && tempMissleSeeker.b_pickTarger5Asteroid2 == false)
        {
            tempMissleSeeker.target4asteriod1Transform.position = collision.gameObject.transform.position;
            tempMissleSeeker.b_pickTarger4Asteroid1 = true;
        }
        if (collision.gameObject.tag == "ASTEROID2" && tempMissleSeeker.b_pickTarger1UFO1 == false && tempMissleSeeker.b_pickTarger2UFO2 == false && tempMissleSeeker.b_pickTarger3UFO3 == false && tempMissleSeeker.b_pickTarger4Asteroid1 == false && tempMissleSeeker.b_pickTarger5Asteroid2 == false)
        {
            tempMissleSeeker.target5asteriod2Transform.position = collision.gameObject.transform.position;
            tempMissleSeeker.b_pickTarger5Asteroid2 = true;
        }
    }



    void Update () {
		
	}
}
