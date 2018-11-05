using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point2Harvester : MonoBehaviour {

    public GameObject go_point2Harvester;
    public Transform point2HarvesterTransform;

    private bool b_turnBack = false;

    void Start()
    {

    }





    void Update()
    {

        if (GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {

            if (point2HarvesterTransform.position.x > 0f)

            {
                b_turnBack = true;
            }

            if (point2HarvesterTransform.position.x < -23f)

            {
                b_turnBack = false;
            }


            if (b_turnBack) { go_point2Harvester.transform.Translate(new Vector3(-0.005f, 0, 0)); }
            if (!b_turnBack) { go_point2Harvester.transform.Translate(new Vector3(0.005f, 0, 0)); }
        }


    }
}
