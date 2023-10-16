using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    public string characterName = "Ahmad";
    int healthPoints = 550;
    float speed = 5.2f;
    bool dead = false;

    void Start()
    {
        // Debug.Log("Hello Unity!");
        PrintHello(characterName);
        Debug.Log(Multiply(2f, 3f));
    }

    void Update()
    {
        speed = speed + 5;
        // Debug.Log(speed);
    }

    // output MethodName(string x, int y)
    void PrintHello (string name)
    {
        Debug.Log("Hello " + name);
    }

    float Multiply(float a, float b)
    {
        float c = a * b;
        return c;
    }
}
