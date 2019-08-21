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

            if (this.transform.rotation.z == 40)
            {
                // If this point is reached, then change the direction

                direction = -1f;
                GUILayout.Label("Test");
            }


        }


        transform.Rotate(new Vector3(0f, 0f, direction));


    }
}
