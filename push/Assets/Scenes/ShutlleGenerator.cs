using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutlleGenerator : MonoBehaviour
{

    public GameObject shutllePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("GenShutlle", 1, 1);
    }

    void GenShutlle () {
		Instantiate (shutllePrefab, new Vector3 (-1, 1, -2), Quaternion.identity);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
