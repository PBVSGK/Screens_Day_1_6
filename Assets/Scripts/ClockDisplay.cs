using UnityEngine;
using TMPro;
using System;

public class ClockDisplay : MonoBehaviour
{
    public TextMeshProUGUI clockDisplay;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            
        clockDisplay.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
