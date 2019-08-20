using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootarrow : MonoBehaviour
{

    private GameObject arrowPrefab;

    // Update is called once per frame
    void Update()
    {
          
            if (Input.GetMouseButtonDown (0) )
            {

            // Choose which arrow to shoot
            arrowPrefab = Resources.Load("arrow") as GameObject;


            // spawn an arrow object on the arrow-shooter position
            GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            newArrow.transform.position = transform.position;


            }
        }
}
