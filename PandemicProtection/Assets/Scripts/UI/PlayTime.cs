using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayTime : MonoBehaviour
{
    public static float time;
    
    public TextMeshProUGUI Timer;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Timer.text = time.ToString("F1");
    }
}
