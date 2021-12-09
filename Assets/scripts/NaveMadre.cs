using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMadre : MonoBehaviour
{
    private Vector2 position;
    private Rigidbody2D rbMadre;  
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;

    private int tipoNaveRandom;
    public int contadorNave;

    void Start()
    {
        rbMadre = GetComponent<Rigidbody2D>();
        InvokeRepeating("Spawn", 1.5f,5);
    }

    void Spawn(){ 

        tipoNaveRandom = Random.Range(1,4);
        if(contadorNave < 4)
        {
            if(tipoNaveRandom == 1)
            {
                position = new Vector2(transform.position.x, transform.position.y - 2f);
                Instantiate(enemy, position, Quaternion.identity);
                contadorNave ++;
            }
            else if(tipoNaveRandom == 2)
            {
                position = new Vector2(transform.position.x, transform.position.y - 3f);
                Instantiate(enemy2, position, Quaternion.identity);
                contadorNave ++;
            }
            else if(tipoNaveRandom == 3)
            {
                position = new Vector2(transform.position.x, transform.position.y - 3f);
                Instantiate(enemy3, position, Quaternion.identity);
                contadorNave ++;
            }
        }
    }
}