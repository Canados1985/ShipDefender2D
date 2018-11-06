using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutBodyCollider : MonoBehaviour {

    

	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scout tempScout = gameObject.transform.parent.GetComponent<Scout>();

        if (collision.gameObject.tag == "ENEMYBULLET" && tempScout.gameObject.name == "scout1")
        {
            FindObjectOfType<AudioManager>().Play("shipExplosion");
            tempScout.DestroyScout();
        }
    }
}
