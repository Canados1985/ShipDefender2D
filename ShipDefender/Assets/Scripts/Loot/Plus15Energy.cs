using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plus15Energy : MonoBehaviour {

    public static Plus15Energy cl_Plus15Energy;

    public GameObject go_Plus15Energy;

    public Transform Plus15EnergyTransform;
    public Transform energyTransform;

    public TextMesh text;
    public Color color;
    

    private float f_counter = 3;

    void Start () {

        f_counter = 3;
        text = GetComponent<TextMesh>();
        color = text.GetComponent<TextMesh>().color;
        //Plus15EnergyTransform.position = Plus15EnergyTransform.position;
        //Plus15EnergyTransform.rotation = Plus15EnergyTransform.rotation;
    }

    private void FixedUpdate()
    {
        //Debug.Log(color.a);

        color.a = color.a - 0.01f;

        f_counter -= Time.deltaTime;
        

    }


    void Update() {

        //Debug.Log(f_counter);
        if (GameStateManager.cl_GameStateManager.b_IsGameIsPaused == false)
        {
            go_Plus15Energy.transform.Translate(new Vector3(0, 0.005f, 0));
        }
        


        if (f_counter <= 0)
        {
            f_counter = 3;
            Destroy(go_Plus15Energy);
        }
        if (f_counter <= 2.5f)
        {

            //EnergyOnClick.cl_EnergyOnClick.b_JustOne = false;
        }
    }
}
