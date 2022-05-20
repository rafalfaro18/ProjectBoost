using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float mainRotation = 100f;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust() {
        if (Input.GetKey(KeyCode.Space)) {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime); // Relative to the object.
        }
    }

    void ProcessRotation() {
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.forward * mainRotation * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.back * mainRotation * Time.deltaTime);
        }
    }
}
