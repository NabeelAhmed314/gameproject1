using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    public bool rotationEnabled = false;
    public float rotationsPerMinute = 0f;

    void Update()
    {
        if (rotationEnabled)
        {
            transform.Rotate(0, 0, -rotationsPerMinute * Time.deltaTime, Space.Self);
        }
        transform.position += new Vector3(1,0,0) * Time.deltaTime * speed;
    }
    
}
