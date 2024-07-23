
using UnityEngine;

public class Gizmos : MonoBehaviour
{
    //Public Attributes
    public Vector2 point1;
    public Vector2 point2;
    public float longitudRay = 1;
    public Transform sphere;   

    //puedo hacer cubo.position y transform.position (en caso de que quiera acceder al transform del propio objeto)

    void Update()
    {
        Debug.DrawLine(point1, point2, Color.magenta); //Aquí dibuja una línea de color magenta desde el punto 1 al punto 2.
        Debug.DrawRay(transform.position, sphere.position * longitudRay, Color.red);
    }
}
