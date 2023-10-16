using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up,
         rotationSpeed * Time.deltaTime);
    }
}
