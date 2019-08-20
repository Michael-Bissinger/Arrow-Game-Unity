﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootarrow : MonoBehaviour
{

    private GameObject arrowPrefab;

    void Start()
    {
        arrowPrefab = Prefabs.Load("arrow.prefab") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
          
            if (Input.GetMouseButtonDown (0) )
            {

            // Choose which arrow to shoot


            // spawn an arrow object on the arrow-shooter position
            GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            newArrow.transform.position = transform.position;


            }
        }
}
