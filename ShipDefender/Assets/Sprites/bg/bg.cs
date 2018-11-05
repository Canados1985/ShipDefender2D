using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour {

    public static bg cl_bg;


    public GameObject go_bg;
    public Transform go_bg_Transform;

    public GameObject go_bg2;
    public Transform go_bg2_Transform;

    public GameObject go_starsbg;
    public Transform go_starsbgTransform;

    public GameObject go_starsbg2;
    public Transform go_starsbg2Transform;

    public GameObject go_frontStarsbg;
    public Transform frontStarsbgTransform;

    public GameObject go_frontStarsbg2;
    public Transform frontStarsbg2Transform;

    public GameObject go_mainCameraInst;
    public Transform mainCameraTransform;

    public GameObject go_GreenPlanet;
    public Transform greenPlanetTransform;

    public GameObject go_RedPlanet;
    public Transform redPlanetTransform;

    public GameObject go_GreyPlanet;
    public Transform greyPlanetTransform;

    public GameObject go_BlackPlanet;
    public Transform blackPlanetTransform;
   

    private bool b_newPosition = false;
    private bool b_newPositionStars = false;
    private bool b_newPositionfrontStars = false;

    void Start() {

        go_bg = GameObject.Find("space_bg");
        go_bg2 = GameObject.Find("space_bg2");
        go_bg_Transform = go_bg.GetComponent<Transform>();
        go_bg2_Transform = go_bg2.GetComponent<Transform>();

        go_starsbg = GameObject.Find("stars_bg");
        go_starsbg2 = GameObject.Find("stars_bg2");
        go_starsbgTransform = go_starsbg.GetComponent<Transform>();
        go_starsbg2Transform = go_starsbg2.GetComponent<Transform>();

        go_frontStarsbg = GameObject.Find("frontStarsbg");
        frontStarsbgTransform = go_frontStarsbg.GetComponent<Transform>();
        go_frontStarsbg2 = GameObject.Find("frontStarsbg2");
        frontStarsbg2Transform = go_frontStarsbg2.GetComponent<Transform>();

        go_mainCameraInst = GameObject.Find("MainCamera");
        mainCameraTransform = go_mainCameraInst.GetComponent<Transform>();

        go_GreenPlanet = GameObject.Find("greenplanet");
        greenPlanetTransform = go_GreenPlanet.GetComponent<Transform>();
        go_RedPlanet = GameObject.Find("redplanet");
        redPlanetTransform = go_GreenPlanet.GetComponent<Transform>();
        go_BlackPlanet = GameObject.Find("blackplanet");
        blackPlanetTransform = go_GreenPlanet.GetComponent<Transform>();
        go_GreyPlanet = GameObject.Find("greyplanet");
        greyPlanetTransform = go_GreenPlanet.GetComponent<Transform>();

    }


    void NewPositionBg1()
    {
        go_bg.transform.Translate(new Vector3(140, 0, 0));
        b_newPosition = false;
    }
    void NewPositionBg2()
    {
        go_bg2.transform.Translate(new Vector3(140, 0, 0));
        b_newPosition = false;
    }

    void newPositionStars1()
    {
        b_newPositionStars = false;
        go_starsbg.transform.Translate(new Vector3(140, 0, 0));
    }

    void newPositionStars2()
    {
        b_newPositionStars = false;
        go_starsbg2.transform.Translate(new Vector3(140, 0, 0));
    }


    void newPositionFrontStars()
    {
        b_newPositionfrontStars = false;
        go_frontStarsbg.transform.Translate(new Vector3(140, 0, 0));
    }

    void newPositionFrontStars2()
    {
        b_newPositionfrontStars = false;
        go_frontStarsbg2.transform.Translate(new Vector3(140, 0, 0));
    }



    void Update() {

        if (GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {
            go_bg.transform.Translate(new Vector3(-0.0005f, 0, 0));
            go_bg2.transform.Translate(new Vector3(-0.0005f, 0, 0));

            go_starsbg.transform.Translate(new Vector3(-0.00065f, 0, 0));
            go_starsbg2.transform.Translate(new Vector3(-0.00065f, 0, 0));

            go_frontStarsbg.transform.Translate(new Vector3(-0.0007f, 0, 0));
            go_frontStarsbg2.transform.Translate(new Vector3(-0.0007f, 0, 0));
        }


        if (go_bg_Transform.position.x + 70 < mainCameraTransform.position.x && b_newPosition == false)
        {
            b_newPosition = true;
            NewPositionBg1();
        }
        if (go_bg2_Transform.position.x + 70 < mainCameraTransform.position.x && b_newPosition == false)
        {
            b_newPosition = true;
            NewPositionBg2();

        }

        if (go_starsbgTransform.position.x + 70 < mainCameraTransform.position.x && b_newPositionStars == false)
        {
            b_newPositionStars = true;
            newPositionStars1();
        }
        if (go_starsbg2Transform.position.x + 70 < mainCameraTransform.position.x && b_newPositionStars == false)
        {
            b_newPositionStars = true;
            newPositionStars2();

        }

        if (frontStarsbgTransform.position.x + 70 < mainCameraTransform.position.x && b_newPositionfrontStars == false)
        {
            b_newPositionfrontStars = true;
            newPositionFrontStars();
        }

        if (frontStarsbg2Transform.position.x + 70 < mainCameraTransform.position.x && b_newPositionfrontStars == false)
        {
            b_newPositionfrontStars = true;
            newPositionFrontStars2();
        }

        // Debug.Log(go_bg2_Transform.position.x);
    }
}
