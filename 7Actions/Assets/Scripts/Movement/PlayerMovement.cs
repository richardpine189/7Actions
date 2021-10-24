using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rbPlayer;
    public bool CanImove { set; get; } = true;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        if (horizontal != 0 && CanImove == true)
        {
            rbPlayer.velocity = new Vector2(0, 0) ;
            rbPlayer.AddForce(Vector3.right * speed * horizontal *Time.deltaTime, ForceMode2D.Impulse);
            CanImove = false;
            EventAction.eventAction();
        }
        if (vertical != 0 && CanImove == true)
        {
            rbPlayer.velocity = new Vector2(0, 0);
            rbPlayer.AddForce(Vector3.up * speed * vertical *Time.deltaTime, ForceMode2D.Impulse);
            CanImove = false;
            EventAction.eventAction();
        }
        
    }
}
