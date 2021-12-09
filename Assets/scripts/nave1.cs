using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave1 : MonoBehaviour
{
    public GameObject bala_nave;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 3);
    }

    void Spawn(){
        Instantiate(bala_nave, new Vector2(transform.position.x, transform.position.y - 1.5f), Quaternion.identity);
        
    }
    
}
