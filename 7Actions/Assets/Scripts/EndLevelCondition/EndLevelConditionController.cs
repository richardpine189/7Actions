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
        UIManager.UIManagerInstance.ShowEndLevelDisplay("Se te acabo el tiempo");
        Invoke("ResetLevel", 1);
    }
    private void OutOfMovement()
    {
        UIManager.UIManagerInstance.ShowEndLevelDisplay("Perdiste, Sin Movimientos");
        Invoke("ResetLevel", 1);
    }
    private void GetToTheGoal()
    {
        UIManager.UIManagerInstance.ShowEndLevelDisplay("Llegue a la meta bien");
        Invoke("ResetLevel", 1);
    }
    private void DontReachAllMovement()
    {
        UIManager.UIManagerInstance.ShowEndLevelDisplay("Te sobraron Movimientos");
        Invoke("ResetLevel", 1);
    }

    public void ResetLevel() // Este metodo deberia estar en otro script
    {
        ActionControl.actionInstance.Reset();
        gameObject.GetComponent<PlayerInitialMovement>().ResetPosition();
        gameObject.GetComponent<TimeController>().ResetTimer();
        UIManager.UIManagerInstance.HideEndLevelDisplay();
        Debug.Log("Resetear Nivel");
    }

    
}
