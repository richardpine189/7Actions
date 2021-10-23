using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public static float TimeCount { private set; get; } = 0;

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        Debug.Log(TimeCount);
        UIManager.UIManagerInstance.UpdateTimerText(TimeCount);
    }
}
