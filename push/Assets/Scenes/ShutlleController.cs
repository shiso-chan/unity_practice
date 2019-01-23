using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutlleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1,0,0));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
        // transform.Translate (0.1f, 0.05f, 0.2f);

        if (transform.position.y < 0) {
			Destroy (gameObject);
        }
    }
}
