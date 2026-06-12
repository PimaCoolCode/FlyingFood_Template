using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int timer = 60;
    [SerializeField] private TMP_Text timertext;

    private void CountDown()
    {
        timer--;
        timertext.text = timer.ToString();
    }

    private void Start()
    {
        timertext.text = timer.ToString();
        InvokeRepeating(nameof(CountDown), 1, 1);
    }
}  