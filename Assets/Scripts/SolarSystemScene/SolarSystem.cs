
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    //Attributes

    //Transform
    public Transform origin;
    public Transform sol;
    public Transform mercurio;
    public Transform venus;
    public Transform camara;
    //SpeedRotation
    private float sunSpeedRotation = 30;
    private float mercurySpeedRotation = 90;
    private float venusSpeedRotation = 45;
    //Angle
    private float rotationAngle = 1;

    //Methods
    void Update()
    {
        InitiateRotation();
    }

    void InitiateRotation()
    {
        //Sun
        sol.transform.RotateAround(origin.position, Vector3.up, rotationAngle * sunSpeedRotation * Time.deltaTime);
        sol.transform.LookAt(origin.position);

        //Mercury
        mercurio.transform.RotateAround(sol.position, Vector3.up, rotationAngle * mercurySpeedRotation * Time.deltaTime);
        mercurio.transform.LookAt(sol.position);

        //Venus
        venus.transform.RotateAround(mercurio.position, Vector3.right, rotationAngle * venusSpeedRotation * Time.deltaTime);
        venus.transform.LookAt(mercurio.position);

        //DrawLines
        Debug.DrawLine(sol.position, origin.position);
        Debug.DrawLine(sol.position, mercurio.position);
        Debug.DrawLine(sol.position, venus.position);
        Debug.DrawLine(mercurio.position, venus.position);

        //Camera
        camara.transform.LookAt(sol.position);
    }
}
