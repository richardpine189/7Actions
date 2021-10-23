using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public void Controller()
    {
        if(TimeCounter.TimeCount > 7)
        {
            //Quitar Una Estrella
        }
        else if(TimeCounter.TimeCount > 14)
        {
            //Quitar Segunda Estrella
        }
        else if(TimeCounter.TimeCount > 21)
        {
            //Quitar Tercer Estrella
        }
        else if(TimeCounter.TimeCount >28)
        {
            EventLevelCondition.outOfTimeEvent();
        }
    }
}
