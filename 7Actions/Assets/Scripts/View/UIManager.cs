using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text actionText;
    [SerializeField] Text adviseText; // Para prototipado debe eliminarse posteriormente.

    public static UIManager UIManagerInstance;

    private void Awake()
    {
            UIManagerInstance = this;
    }

    public void UpdateTimerText(float t)
    {
        
        timerText.text = $"Timer: {Math.Round(t, 2)}";
    }
    public void UpdateActionText(int a)
    {
        actionText.text = $"Actions Left: {a}";
    }

    public void ShowEndLevelDisplay(string message)
    {
        adviseText.text = message;
        adviseText.gameObject.SetActive(true);
    }
}
