﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * 5, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Time.deltaTime * 5, 0, Space.World);
        }
    }
}