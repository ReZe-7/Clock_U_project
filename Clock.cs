using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hourTransform;
    public Transform minuteTransform;
    public Transform secondTransform;
    const float
        degreesPerHour = 30f,
        degreesPerMinute = 6f,
        degreesPerSecond = 6f;
    public bool Continuous ;
    // Above Refrence can also be made by the -------> Style given Below :)
    // public Transform hourTransform, minuteTransform, secondTransform ;
    private void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minuteTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondTransform.localRotation = Quaternion.Euler(0f, (float)(time.TotalSeconds * degreesPerSecond), 0f);

    }
    private void UpdateDiscrete()
    {
        Debug.Log(DateTime.Now);
        DateTime time = DateTime.Now;
        hourTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minuteTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }
}
