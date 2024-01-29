using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject rotator;
    public Transform spawn1;
    public Transform spawn2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(rotator, spawn1.position, spawn1.rotation);
        Instantiate(rotator, spawn2.position, spawn2.rotation);
    }
}
