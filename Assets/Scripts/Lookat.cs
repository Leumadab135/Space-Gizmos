using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    //Public Attributes
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(target); 
    }
}
