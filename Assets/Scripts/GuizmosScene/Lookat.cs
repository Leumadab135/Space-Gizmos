
using UnityEngine;

public class Lookat : MonoBehaviour
{
    //Public Attributes
    public Transform target;

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(target); 
    }
}
