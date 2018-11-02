using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : MonoBehaviour {

    public static Scout cl_Scout;

    GameObject target;
    Quaternion rotateToTarget;

    private Vector3 v3_Scout;
    public Transform targetTransform;

    public GameObject go_Scout;
    public Rigidbody2D rb_Scout;
    public GameObject bulletRef;
    public GameObject gunSpriteInst;


    public Transform scoutTransform;
    public Transform mainStationTransformInst;


    public List<GameObject> go_bulletListS1;
    private GameObject bulletContainerS1;

    public List<GameObject> go_bulletListS2;
    private GameObject bulletContainerS2;

    public List<GameObject> go_bulletListS3;
    private GameObject bulletContainerS3;

    public List<GameObject> go_bulletListS4;
    private GameObject bulletContainerS4;


    public bool b_IsAimed_Scout1 = false;
    public bool b_backOnBase_Scout1 = false;

    public bool b_IsAimed_Scout2 = false;
    public bool b_backOnBase_Scout2 = false;

    public bool b_IsAimed_Scout3 = false;
    public bool b_backOnBase_Scout3 = false;

    public bool b_IsAimed_Scout4 = false;
    public bool b_backOnBase_Scout4 = false;

    public float f_counter = 0f;

    private float f_rotationSpeed = 50f;
    private float f_speed = 2f;

    public bool b_IsShoting = false;


    void Start () {

        cl_Scout = this;

        target = GameObject.Find("pointRanger");
        targetTransform = target.GetComponent<Transform>();

        if (this.gameObject.name == "scout1")
        {
            cl_Scout = this;
            go_Scout = GameObject.Find("scout1");
            scoutTransform = go_Scout.GetComponent<Transform>();
            target = GameObject.Find("pointRanger");
            targetTransform = target.GetComponent<Transform>();
            gunSpriteInst.SetActive(false);

            //Bullets list for Scout1
            go_bulletListS1 = new List<GameObject>();
            bulletContainerS1 = GameObject.Find("scout1/gun");
            for (int i = 0; i < 25; i++)
            {
                GameObject temp = Instantiate(bulletRef);
                temp.SetActive(false);
                go_bulletListS1.Add(temp);
                go_bulletListS1[i].transform.parent = bulletContainerS1.transform;
                go_bulletListS1[i].name = "bulletSC1";
            }

        }


        if (this.gameObject.name == "scout2")
        {
            cl_Scout = this;
            go_Scout = GameObject.Find("scout2");
            scoutTransform = go_Scout.GetComponent<Transform>();
            target = GameObject.Find("pointRanger");
            targetTransform = target.GetComponent<Transform>();
            gunSpriteInst.SetActive(false);

            //Bullets list for Scout2
            go_bulletListS2 = new List<GameObject>();
            bulletContainerS2 = GameObject.Find("scout2/gun");
            for (int i = 0; i < 25; i++)
            {
                GameObject temp = Instantiate(bulletRef);
                temp.SetActive(false);
                go_bulletListS2.Add(temp);
                go_bulletListS2[i].transform.parent = bulletContainerS2.transform;
                go_bulletListS2[i].name = "bulletSC2";
            }
        }


        if (this.gameObject.name == "scout3")
        {
            cl_Scout = this;
            go_Scout = GameObject.Find("scout3");
            scoutTransform = go_Scout.GetComponent<Transform>();
            target = GameObject.Find("pointRanger");
            targetTransform = target.GetComponent<Transform>();
            gunSpriteInst.SetActive(false);

            //Bullets list for Scout3
            go_bulletListS3 = new List<GameObject>();
            bulletContainerS3 = GameObject.Find("scout3/gun");
            for (int i = 0; i < 25; i++)
            {
                GameObject temp = Instantiate(bulletRef);
                temp.SetActive(false);
                go_bulletListS3.Add(temp);
                go_bulletListS3[i].transform.parent = bulletContainerS3.transform;
                go_bulletListS3[i].name = "bulletSC3";
            }
        }



        if (this.gameObject.name == "scout4")
        {
            cl_Scout = this;
            go_Scout = GameObject.Find("scout4");
            scoutTransform = go_Scout.GetComponent<Transform>();
            target = GameObject.Find("pointRanger");
            targetTransform = target.GetComponent<Transform>();
            gunSpriteInst.SetActive(false);

            //Bullets list for Scout4
            go_bulletListS4 = new List<GameObject>();
            bulletContainerS4 = GameObject.Find("scout4/gun");
            for (int i = 0; i < 25; i++)
            {
                GameObject temp = Instantiate(bulletRef);
                temp.SetActive(false);
                go_bulletListS4.Add(temp);
                go_bulletListS4[i].transform.parent = bulletContainerS4.transform;
                go_bulletListS4[i].name = "bulletSC4";
            }
        }


    }

          
    private void OnEnable()
    {
        //missleTransform.position = rangerTransform.position;
    }

    private void Disable()
    {

    }



    //Set fire for Scout1
    public GameObject FireS1()
    {
        for (int i = 0; i < 25; i++)
        {
            if (!go_bulletListS1[i].activeSelf)
            {

                go_bulletListS1[i].transform.position = bulletContainerS1.transform.position;
                go_bulletListS1[i].transform.rotation = bulletContainerS1.transform.rotation;
                go_bulletListS1[i].SetActive(true);
                return go_bulletListS1[i];

            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS1.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout2
    public GameObject FireS2()
    {
        for (int i = 0; i < 25; i++)
        {
            if (!go_bulletListS2[i].activeSelf)
            {
                go_bulletListS2[i].transform.position = bulletContainerS2.transform.position;
                go_bulletListS2[i].transform.rotation = bulletContainerS2.transform.rotation;
                go_bulletListS2[i].SetActive(true);
                return go_bulletListS2[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS2.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout3
    public GameObject FireS3()
    {
        for (int i = 0; i < 25; i++)
        {
            if (!go_bulletListS3[i].activeSelf)
            {
                go_bulletListS3[i].transform.position = bulletContainerS3.transform.position;
                go_bulletListS3[i].transform.rotation = bulletContainerS3.transform.rotation;
                go_bulletListS3[i].SetActive(true);
                return go_bulletListS3[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS3.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    //Set fire for Scout4
    public GameObject FireS4()
    {
        for (int i = 0; i < 25; i++)
        {
            if (!go_bulletListS4[i].activeSelf)
            {
                go_bulletListS4[i].transform.position = bulletContainerS4.transform.position;
                go_bulletListS4[i].transform.rotation = bulletContainerS4.transform.rotation;
                go_bulletListS4[i].SetActive(true);
                return go_bulletListS4[i];
            }
        }
        GameObject temp = Instantiate(bulletRef);
        //Debug.Log(temp);
        go_bulletListS4.Add(temp);
        temp.SetActive(true);
        return temp;
    }

    void Update () {
		
	}

    void FixedUpdate()
    {

        if (b_IsShoting == false)
        {

            v3_Scout = (target.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(v3_Scout.y, v3_Scout.x) * Mathf.Rad2Deg;
            rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * f_rotationSpeed);

            rb_Scout.velocity = transform.up * f_speed;
        }
        if (b_IsShoting == true)
        {
            v3_Scout = (target.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(v3_Scout.y, v3_Scout.x) * Mathf.Rad2Deg;
            rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * f_rotationSpeed / 2);
            rb_Scout.velocity = transform.up * f_speed / 2;

        }




    }

}
