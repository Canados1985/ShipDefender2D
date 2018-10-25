using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour {

    public static Missle cl_Missle;

	public GameObject go_Missle;
    public Rigidbody rb_Missle;

    public Transform missleTransform;

    public Transform rangerTransform;

	void Start () {

        rangerTransform = GameObject.Find("ranger").transform;
        //go_Missle = GameObject.Find("missle");
        missleTransform = go_Missle.GetComponent<Transform>();
       
        missleTransform.position = rangerTransform.position;
        
    }


    private void OnEnable()
    {
        Invoke("Disable", 2f);
        //missleTransform.position = rangerTransform.position;
    }

    private void Disable()
    {
        go_Missle.SetActive(false);
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "UFO")

        {
            Debug.Log("MISSLE HITS UFO");
        }
    }


    void Update () {

        rb_Missle.AddForce(new Vector3(8f,0,0));

        if (missleTransform.position.x > 50 || missleTransform.position.x < -50 || missleTransform.position.y > 50 || missleTransform.position.y < -50)
        {
            go_Missle.SetActive(false);
        }
	}


}
