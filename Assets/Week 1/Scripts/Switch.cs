using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    SpriteRenderer spriteRendererer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRendererer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger");
        spriteRendererer.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRendererer.color = Color.blue;
    }
}
