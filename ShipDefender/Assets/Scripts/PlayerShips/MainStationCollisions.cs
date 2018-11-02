using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStationCollisions : MonoBehaviour {



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ASTEROID")
        {
            MainStation.cl_MainStation.f_mainStationHealth = MainStation.cl_MainStation.f_mainStationHealth - 15f;
            Asteroid_1.cl_Asteroid1.DestroyAsteroid();

        }
        if (collision.gameObject.tag == "ASTEROID2")
        {
            MainStation.cl_MainStation.f_mainStationHealth = MainStation.cl_MainStation.f_mainStationHealth - 15f;
            Asteroid_2.cl_Asteroid2.DestroyAsteroid();
        }
    }
}
