using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 3f;
    public float verticalRotationSpeed = 30f;

    private float currentSpeed = 0f;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float verticalRotationAmount = verticalInput * verticalRotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.right, verticalRotationAmount);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float turnInput = Input.GetAxis("Horizontal");

        float rotationAmount = turnInput * rotationSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, rotationAmount, 0f);
        transform.rotation *= turnRotation;
    }
}
