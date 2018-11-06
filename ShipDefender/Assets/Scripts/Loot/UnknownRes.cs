using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnknownRes : MonoBehaviour {

    public GameObject go_UnknownRes;
    public Transform unknownResTransform;

    public GameObject go_Text;
    private Vector3 v3_Resource;

    public bool b_IsCollecting = false;
    public bool b_IsBusy = false;

    private float f_counter = 10f;

    void Start () {

        go_UnknownRes.gameObject.name = "resource";
        b_IsCollecting = false;

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "harvestergun") // < ---- I think I need to add one more bool from Harvester
        {
            this.b_IsCollecting = true;
        }
        if (collision.gameObject.name == "missleR1")
        {
            
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("explosion");
        }
        if (collision.gameObject.name == "missleR2")
        {
            
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("explosion");
        }
        if (collision.gameObject.name == "missleR3")
        {
            
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("explosion");
        }
    }

    private void FixedUpdate()
    {
        if (this.b_IsCollecting == true)
        {
            f_counter -= Time.deltaTime;
        }
        if (f_counter <= 0)
        {
            Instantiate(go_Text, this.v3_Resource, new Quaternion());
            MainStation.cl_MainStation.f_mainStationResource = MainStation.cl_MainStation.f_mainStationResource + 20;
            f_counter = 10f;
            this.b_IsCollecting = false;
            Destroy(this.gameObject);

        }
    }


    void Update () {

        v3_Resource.x = unknownResTransform.position.x;
        v3_Resource.y = unknownResTransform.position.y;
        v3_Resource.z = unknownResTransform.position.z;

        if (this.b_IsCollecting == false && GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {
            go_UnknownRes.transform.Translate(new Vector3(-0.0055f, 0, 0));

            if (go_UnknownRes.transform.position.x < -50f)
            { Destroy(this.gameObject); }
        }

        

    }
}
