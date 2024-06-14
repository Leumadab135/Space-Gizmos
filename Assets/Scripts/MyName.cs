using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    void Update()
    {
        Debug.DrawLine(new Vector2(0,0), new Vector2(1,1));
        Debug.DrawLine(new Vector2(1,1), new Vector2(0,2));
        Debug.DrawLine(new Vector2(0,2), new Vector2(1,3));
        Debug.DrawLine(new Vector2(2,0), new Vector2(3,3));
        Debug.DrawLine(new Vector2(3,3), new Vector2(4,0));
        Debug.DrawLine(new Vector2(2.5f, 1.5f), new Vector2(3.5f,1.5f));
        Debug.DrawLine(new Vector2(5,0), new Vector2(5,3));
        Debug.DrawLine(new Vector2(5,3), new Vector2(6,1));
        Debug.DrawLine(new Vector2(6,1), new Vector2(7,3));
        Debug.DrawLine(new Vector2(7,3), new Vector2(7,0));
        Debug.DrawLine(new Vector2(8,3), new Vector2(9,0));
        Debug.DrawLine(new Vector2(9,0), new Vector2(10,3));
        Debug.DrawLine(new Vector2(11,0), new Vector2(12.5f,0));
        Debug.DrawLine(new Vector2(11,0), new Vector2(11,3));
        Debug.DrawLine(new Vector2(11,3), new Vector2(12.5f,3));
        Debug.DrawLine(new Vector2(11,1.5f), new Vector2(12,1.5f));
        Debug.DrawLine(new Vector2(13,0), new Vector2(14,0));
        Debug.DrawLine(new Vector2(13,0), new Vector2(13,3));
    }
}
