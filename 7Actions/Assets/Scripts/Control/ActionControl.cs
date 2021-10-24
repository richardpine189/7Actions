using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionControl : MonoBehaviour
{
    public int Action { private set; get; } = 7;
    public static ActionControl actionInstance;

    private void Awake()
    {
        actionInstance = this;
        
    }
    private void Start()
    {
        SendActionToUI(Action);
        EventAction.eventAction += RealizeAction;
    }
    private void OnDestroy()
    {
        EventAction.eventAction -= RealizeAction;
    }
    public void RealizeAction()
    {
        if (Action >= 0)
        {
            Action = Action - 1;
            
        }
        if(Action < 0)
        {
            EventLevelCondition.outOfMovementEvent();
        }
        SendActionToUI(Action);
    }

    public void Reset()
    {
        Action = 7;
        SendActionToUI(Action);
    }

    private void SendActionToUI(int action)
    {
        UIManager.UIManagerInstance.UpdateActionText(action);
    }

}
