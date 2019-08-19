using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.position += Vector3.left;

        // Move the object upward in world space 1 unit/second.
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
