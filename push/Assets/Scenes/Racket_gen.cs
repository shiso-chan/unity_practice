using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket_gen : MonoBehaviour
{

    public GameObject RacketPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate (RacketPrefab, new Vector3 (1, 2, -2), Quaternion.Euler(90, 0, 90));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
