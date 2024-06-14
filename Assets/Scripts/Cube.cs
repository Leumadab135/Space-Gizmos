using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

        //Debug.DrawLine(new Vector3(), new Vector3());    }

    void Update()
    {
        Debug.DrawLine(new Vector3(0,4), new Vector3(2,4));
        Debug.DrawLine(new Vector3(0,4), new Vector3(0,6));
        Debug.DrawLine(new Vector3(2,4), new Vector3(2,6));
        Debug.DrawLine(new Vector3(0,6), new Vector3(2,6));
        Debug.DrawLine(new Vector3(0, 4, 2), new Vector3(2, 4, 2));
        Debug.DrawLine(new Vector3(0, 4, 2), new Vector3(0, 6, 2));
        Debug.DrawLine(new Vector3(2, 4, 2), new Vector3(2, 6, 2));
        Debug.DrawLine(new Vector3(0, 6, 2), new Vector3(2, 6, 2));
        Debug.DrawLine(new Vector3(0,4,0), new Vector3(0,4,2));
        Debug.DrawLine(new Vector3(2,4,0), new Vector3(2,4,2));
        Debug.DrawLine(new Vector3(0,6,0), new Vector3(0,6,2));
        Debug.DrawLine(new Vector3(2,6,0), new Vector3(2,6,2));



    }
}
