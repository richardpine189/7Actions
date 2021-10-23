using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningActivator : MonoBehaviour
{
    //Accedo al SpriteRender para cambiar el color a modo de prototipo.
    [SerializeField] SpriteRenderer spriteR;
    [SerializeField] Color originalColor;
    [SerializeField] Color lightningColor = new Color();
    private void Start()
    {
        spriteR = GetComponentInParent<SpriteRenderer>();
        originalColor = spriteR.color;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteR.color = lightningColor;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteR.color = originalColor;
        }
    }
}
