using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerText : MonoBehaviour
{
    public TMP_Text timerText;
    public float countdown;

    void Update()
    {
        countdown = GameManager.instance.remainingTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        timerText.text = "Remaining Time: " + string.Format("{0:00.00}", countdown) + "s";
    }
}
