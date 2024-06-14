using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Public Attributes
    public Transform playerTransform;
    public Transform sphereTransform;
    public Vector3 punto1 = new Vector3(0, 0, 0);
    public float speed;
    public float speedRotation;
    public float speedSphere;
    public bool saltar;

    //Private Attributes
    private float _rotationAngle = 0;
    private bool descender;

    //public methods
    public void Salto () 
    {
        if (saltar)
        {
            speed += 100 * Time.deltaTime;
            playerTransform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (speed >= 20)
        {
            saltar = false;
            descender = true;
        }

        if (descender)
        {
            speed -= 100 * Time.deltaTime;
            playerTransform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (playerTransform.position.y <= 0)
        {
            speed = 1;
            saltar = false;
            descender = false;
            playerTransform.position = punto1;
        }
    }   

    private void Update()
    {
        Salto();

        //Tambien podemos rotar
        playerTransform.Rotate(Vector3.forward * speedRotation * Time.deltaTime);

        //Y sobre un objeto
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, _rotationAngle * speedSphere * Time.deltaTime );
        _rotationAngle ++;
    }
}
