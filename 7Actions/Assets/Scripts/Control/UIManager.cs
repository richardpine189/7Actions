using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text actionText;

    public static UIManager UIManagerInstance;

    private void Awake()
    {
        
            UIManagerInstance = this;
        
    }
    private UIManager()
    {
            
        
    }

    public void UpdateTimerText(int t)
    {
        timerText.text = $"Timer: {t}";
    }
    public void UpdateActionText(int a)
    {
        actionText.text = $"Actions Left: {a}";
    }
}
