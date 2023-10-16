using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    string characterName = "Ahmad";
    int healthPoints = 550;
    float speed = 5.2f;
    bool dead = false;

    void Start()
    {
        Debug.Log(speed);
    }

    void Update()
    {
        speed = speed + 5;
        Debug.Log(speed);
    }
}
