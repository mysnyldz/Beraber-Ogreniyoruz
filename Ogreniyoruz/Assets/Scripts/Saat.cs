using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Saat : MonoBehaviour
{
    private const float Real_Seconds_per_ingame_day=60f;
    private Transform clockHourhandTransform;
    private Transform clockMinutehandTransform;
    public GameObject Alarmkolu;
    public GameObject bolumsonu; 
    public GameObject SaatkurmaGo;
    private Text timeText;
    private float day;
    public void alarm()
    {
        Alarmkolu.transform.Rotate(0f,0f,-6f);    
    }
    public void alarmButonu()
    {
        SaatkurmaGo.SetActive(false);
        bolumsonu.SetActive(true);
    }
    private void Awake() 
    {
        clockHourhandTransform=transform.Find("saatkolu");
        clockMinutehandTransform=transform.Find("dakikakolu");
        timeText = transform.Find("timeText").GetComponent<Text>();
    }
    private void Update()
    {
        day+= Time.deltaTime/Real_Seconds_per_ingame_day;
        float dayNormalized=day % 1f;
        
        float rotationDegreesPerDay=720f;
        clockHourhandTransform.eulerAngles= new Vector3(0,0,-dayNormalized * rotationDegreesPerDay);
        
        float hoursperday=24f;
        clockMinutehandTransform.eulerAngles= new Vector3(0,0,-dayNormalized * rotationDegreesPerDay*12f);
        
        string hoursstring= Mathf.Floor(dayNormalized*hoursperday).ToString("00");
        float minutesPerHour=60f; 
        string minutesString=Mathf.Floor(((dayNormalized*hoursperday)%1f)*minutesPerHour).ToString("00");

        timeText.text=hoursstring+":"+minutesString;
        
    }
}
