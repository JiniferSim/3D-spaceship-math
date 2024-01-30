using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 3f;

    private Quaternion zQuater;
    private Quaternion yQuater;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float turnInput = Input.GetAxis("Horizontal");

        zQuater = new Quaternion(0f, 0f, Mathf.Sin(turnInput * rotationSpeed * Time.deltaTime / 2), Mathf.Cos(turnInput * rotationSpeed * Time.deltaTime / 2));
        transform.rotation *= zQuater;

        yQuater = new Quaternion(0f, Mathf.Sin(turnInput * rotationSpeed * Time.deltaTime / 2), 0f, Mathf.Cos(turnInput * rotationSpeed * Time.deltaTime / 2));
        transform.rotation *= yQuater;

        //Quaternion currentRotation = transform.rotation;
        //Quaternion newXRotation = new Quaternion(0f, currentRotation.y, currentRotation.z, currentRotation.w);
        //transform.rotation = newXRotation;
    }
}
