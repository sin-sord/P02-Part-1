using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSwitch : MonoBehaviour
{
    public GameObject Gate;
    public GameObject Switch;
    public GameObject SwitchReset;
    SpriteRenderer spriteRenderer;
    public Transform SwitchSpawn;

    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Gate.activeInHierarchy)
        {
            Gate.SetActive(false);
            spriteRenderer.color = Color.red;
        } else
        {
            Gate.SetActive(true);
            spriteRenderer.color= Color.green;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Gate.activeInHierarchy)
        {
            Gate.SetActive(false);
        } else
        {
            Gate.SetActive(true);
        }
    }

}
