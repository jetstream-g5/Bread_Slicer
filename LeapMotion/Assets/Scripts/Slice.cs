﻿using UnityEngine;
using System.Collections;

public class Slice : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -60f)
        {
            Destroy(this.gameObject);
        }
    }

}