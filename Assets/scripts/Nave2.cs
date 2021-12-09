using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave2 : MonoBehaviour
{
    public GameObject bala_nave2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.2f, 2.5f);
    }

    void Spawn()
    {
        Instantiate(bala_nave2, new Vector2(transform.position.x + 1, transform.position.y - 1.2f), Quaternion.identity);
    }
}
