using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionControl : MonoBehaviour
{
    public int Action { private set; get; } = 7;

    private void Awake()
    {
        SendActionToUI(Action);
    }
    private void Start()
    {
        EventAction.eventAction += RealizeAction;
    }
    private void OnDestroy()
    {
        EventAction.eventAction -= RealizeAction;
    }
    public void RealizeAction()
    {
        if (Action > 0)
        {
            Action = Action - 1;
            
        }
        SendActionToUI(Action);
    }

    private void SendActionToUI(int action)
    {
        UIManager.UIManagerInstance.UpdateActionText(action);
    }

}
