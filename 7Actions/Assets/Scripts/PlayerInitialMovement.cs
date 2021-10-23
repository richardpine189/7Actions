using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitialMovement : MonoBehaviour
{
    private Vector3 initialPosition;
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = player.transform.position;
        Debug.Log(initialPosition);
    }

    public void ResetPosition()
    {
        Debug.Log("Reseteo Posicion");
        player.transform.position = initialPosition;
        Debug.Log(player.transform.position);
    }

}
