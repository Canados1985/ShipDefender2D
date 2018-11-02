using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject go_Explosion;
    public Transform explosionTransform;
    
    private float f_counter = 0.9f;
	void Start () {

        go_Explosion.gameObject.name = "explosion";

        go_Explosion = GameObject.Find("explosion");
        explosionTransform = go_Explosion.GetComponent<Transform>();
        //go_Explosion.transform.Translate (new Vector3 (explosionTransform.position.x, explosionTransform.position.y, explosionTransform.position.z));
    }


    private void FixedUpdate()
    {
        f_counter -= Time.deltaTime;
    }

    void Update () {

        if (f_counter <= 0)
        {
            Destroy(this.gameObject);
        }


    }
}
