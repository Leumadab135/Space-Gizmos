
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //Public Attributes
    public Transform initialTransform;
    public Transform finalTransform;
    public float speed = 1;

    //Private Attributes
    private Vector3 _directionVector;       //Fórmula para los vectores, extremo - origen

    // Update is called once per frame
    void Update()
    {

        _directionVector = finalTransform.position - initialTransform.position;
        
        //Convierte el vector en unitario 
        _directionVector.Normalize();
        
        //Un atajo para new Vector3(0,0,0) es Vector3.zero  
        Debug.DrawRay(initialTransform.position, _directionVector * speed);  
        
        //Translación del cubo1 por el vector dirección con una velocidad determinada. ".Normalize" para mantener uniformidad
        initialTransform.Translate(_directionVector * speed * Time.deltaTime);

        //La magnitud es la representación del vector dirección. Cuanto más grande es el vector, es mayor su magnitud.
        print("Magnitude: " +  _directionVector.magnitude);

        //La distancia es muy importante para detectar colisiones, rangos de area, etc.
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " +  Vector3.Distance(initialTransform.position,finalTransform.position));

        //Prueba de seguimiento según una distancia
        if (distance < 10)
        {
            initialTransform.Translate(_directionVector * speed * Time.deltaTime);
        }
    }
}
