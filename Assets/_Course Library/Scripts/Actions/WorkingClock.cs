
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MyClockScript : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;
    int currentHour;
    int currentMinute;
    int currentSecond;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentHour = System.DateTime.Now.Hour;
        currentMinute = System.DateTime.Now.Minute;
        currentSecond = System.DateTime.Now.Second;


        hourHand.localRotation = Quaternion.Euler(currentHour * 30, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(currentMinute * 6, 0, 0); 
        secondHand.localRotation = Quaternion.Euler(currentSecond * 6, 0, 0);
    }
}