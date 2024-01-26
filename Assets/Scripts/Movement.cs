using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    //public float frequency = 1.0f;
    //public float tilte = 30f;
    public float rotationSpeed = 3f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float turnInput = Input.GetAxis("Horizontal");

        float rotationAmount = turnInput * rotationSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, rotationAmount, 0f);
        transform.rotation *= turnRotation;
    }
}
