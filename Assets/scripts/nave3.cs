using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave3 : MonoBehaviour
{
    public GameObject bala_nave;
    
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 3);
    }

    void Spawn()
    {
        Instantiate(bala_nave, new Vector2(transform.position.x, transform.position.y - 1f), Quaternion.identity);
        Instantiate(bala_nave, new Vector2(transform.position.x + 0.5f, transform.position.y - 2f), Quaternion.identity);
        Instantiate(bala_nave, new Vector2(transform.position.x - 0.5f, transform.position.y - 3f), Quaternion.identity);
    }
    
}