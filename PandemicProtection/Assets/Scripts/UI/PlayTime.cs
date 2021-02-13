﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public static float time;
    
    public Text Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Timer.text = "Time Elapsed: " + time.ToString("F1");
    }
}