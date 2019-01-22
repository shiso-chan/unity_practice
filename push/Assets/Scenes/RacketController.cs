using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.1f, 0, 0);
        }   
        if (Input.GetKeyDown (KeyCode.Space)){
            transform.Rotate (new Vector3(30f, 0f, 0f));
        }
        if (Input.GetKeyUp (KeyCode.Space)){
            transform.Rotate (new Vector3(-30f, 0f, 0f));
        }
    }

    void OnCollisionEnter(Collision coll) {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 10000000000);

    }
}
