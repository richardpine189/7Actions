using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (ActionControl.actionInstance.Action != 0) // OverCodeado
            {
                EventLevelCondition.wrongMovementEvent();
            }
            else
            {
                EventLevelCondition.getToTheGoal();
            }
        }
    }
}
