using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus15Res : MonoBehaviour {

    public static Plus15Res cl_Plus15Res;

    public GameObject go_Plus15Res;

    public Transform Plus15ResTransform;
    public Transform resTransform;

    public TextMesh text;
    public Color color;


    private float f_counter = 3;

    void Start () {

        f_counter = 3;
        text = GetComponent<TextMesh>();
        color = text.GetComponent<TextMesh>().color;
        //Plus15ResTransform.position = Plus15ResTransform.position;
        //Plus15ResTransform.rotation = Plus15ResTransform.rotation;

    }


    private void FixedUpdate()
    {
        //Debug.Log(color.a);

        color.a = color.a - 0.01f;

        f_counter -= Time.deltaTime;


    }

  
    void Update () {

        //Debug.Log(f_counter);

        if (GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {
            go_Plus15Res.transform.Translate(new Vector3(0, 0.005f, 0));
        }
        


        if (f_counter <= 0)
        {
            f_counter = 3;
            Destroy(go_Plus15Res);
        }
        if (f_counter <= 2.5f)
        {

            //EnergyOnClick.cl_EnergyOnClick.b_JustOne = false;
        }

    }
}
