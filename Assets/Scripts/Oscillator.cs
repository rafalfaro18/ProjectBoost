using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;

    
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period == 0) { return; }
        float cycles = Time.time / period; // continually growing over time.
        const float tau = Mathf.PI * 2; // A full cycle of a sine wave 6.283.
        float rawSineWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movementFactor = (rawSineWave + 1f) / 2; // recalculated to 0-1 instead of -1 to 1. Comes back to the origin point.

        Vector3 offset = movementVector * movementFactor;
        transform.position = offset;
    }
}
