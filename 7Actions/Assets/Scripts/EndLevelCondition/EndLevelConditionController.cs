using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelConditionController : MonoBehaviour
{
    private void Start()
    {
        EventLevelCondition.outOfTimeEvent += OutOfTime;
        EventLevelCondition.outOfMovementEvent += OutOfMovement;
        EventLevelCondition.wrongMovementEvent += DontReachAllMovement;
        EventLevelCondition.getToTheGoal += GetToTheGoal;
    }

    private void OnDestroy()
    {
        EventLevelCondition.outOfTimeEvent -= OutOfTime;
        EventLevelCondition.outOfMovementEvent -= OutOfMovement;
        EventLevelCondition.wrongMovementEvent -= DontReachAllMovement;
        EventLevelCondition.getToTheGoal -= GetToTheGoal;
    }

    private void OutOfTime()
    {
        Debug.Log("Se me acabó el tiempo");
    }
    private void OutOfMovement()
    {
        Debug.Log("Se me acabaron los movimientos");
    }
    private void GetToTheGoal()
    {
        Debug.Log("Llegue a la meta bien");
    }
    private void DontReachAllMovement()
    {
        Debug.Log("Llegue a la meta y me quedan movimientos");
    }
}
