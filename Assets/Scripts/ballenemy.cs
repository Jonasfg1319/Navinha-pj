﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballenemy : MonoBehaviour
{
    private float speed = -700f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,speed * Time.deltaTime);

    }
    
}
