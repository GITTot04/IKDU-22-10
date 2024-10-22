using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekdaysHomework : MonoBehaviour
{
    string[] weekdays = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };
    void Start()
    {
        WeeklyScheduleIfElse();
        WeeklyScheduleSwitchCase();
    }
    /// <summary>
    /// Explains my weekly schedule in console by using a for-loop
    /// </summary>
    void WeeklyScheduleIfElse()
    {
        Debug.Log("For-loop using an array and many if-else statements");
        for (int i = 0; i < weekdays.Length; i++)
        {
            Debug.Log("Today is " + weekdays[i]);
            if (weekdays[i] == "Monday")
            {
                Debug.Log("I have to do group work");
            }
            else if (weekdays[i] == "Tuesday")
            {
                Debug.Log("I have to attend the first programming lesson of the week");
            }
            else if (weekdays[i] == "Wednesday")
            {
                Debug.Log("I have to attend a PBL lesson");
            }
            else if (weekdays[i] == "Thursday")
            {
                Debug.Log("I have to attend the second programming lesson of the week");
            }
            else if (weekdays[i] == "Friday")
            {
                Debug.Log("I have to do group work and later work at the theater");
            }
            else if (weekdays[i] == "Saturday")
            {
                Debug.Log("I have to relax and spend time with family and friends");
            }
            else
            {
                Debug.Log("I have to get ready for the next week");
            }
        }
    }
    /// <summary>
    /// Explains my weekly schedule in console using a switch-case
    /// </summary>
    void WeeklyScheduleSwitchCase()
    {
        Debug.Log("While-loop using an array and a switch-case statement");
        int j = 0;
        while (j < weekdays.Length)
        {
            Debug.Log("Today is " + weekdays[j]);
            switch (weekdays[j])
            {
                case "Monday":
                    Debug.Log("I have to do group work");
                    break;
                case "Tuesday":
                    Debug.Log("I have to attend the first programming lesson of the week");
                    break;
                case "Wednesday":
                    Debug.Log("I have to attend a PBL lesson");
                    break;
                case "Thursday":
                    Debug.Log("I have to attend the second programming lesson of the week");
                    break;
                case "Friday":
                    Debug.Log("I have to do group work and later work at the theater");
                    break;
                case "Saturday":
                    Debug.Log("I have to relax and spend time with family and friends");
                    break;
                default:
                    Debug.Log("I have to get ready for the next week");
                    break;
            }
            j++;
        }
    }
}