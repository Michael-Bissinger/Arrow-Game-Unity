using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBow : MonoBehaviour
{
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (direction == 1f)
        {

            if (transform.Rotate(new Vector3(0f, 0f, -40f)))
            {
                // If this point is reached, then change the direction

                direction = -1f;
            }


        }


        transform.Rotate(new Vector3(0f, 0f, direction));


    }
}
