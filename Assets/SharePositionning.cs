﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharePositionning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        {
            gameObject.transform.position = new Vector3(120, 120);
        }
        else
        {
            gameObject.transform.position = new Vector3(150, 150);
        }
    }
}
