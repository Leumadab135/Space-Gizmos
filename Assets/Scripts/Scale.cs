using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //Public Attributes
    public float scaleX = 1;

    void Update()
    {
        // En x, la escala local será 1, mientras que las demás escalas se mantienen igual 
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
    }
}
