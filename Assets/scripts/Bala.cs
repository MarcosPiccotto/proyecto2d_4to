using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bala : MonoBehaviour
{
    
    private int plata;
    public GameObject puntos;
    public GameController variable;
    public GameObject goNaveMadre;
    public NaveMadre naveMadre;
    private int contadorBalas;
    
    // Start is called before the first frame update
    void Start()
    {
        puntos = GameObject.Find("GameControler");
        variable = puntos.GetComponent<GameController>();
        
        goNaveMadre = GameObject.Find("NaveMadre");
        naveMadre = goNaveMadre.GetComponent<NaveMadre>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, 5f) * Time.deltaTime);
    }   
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemigo" )
        {
            Destroy(col.gameObject);
            variable.ActualizarPuntos();  
            naveMadre.contadorNave--;

        }
        if(col.gameObject.tag == "balaEnemiga" )
        {
            Destroy(col.gameObject);
            variable.ActualizarPuntosBalas();            
        }
    }

    void OnBecameInvisible(){
        Destroy(gameObject);
    }
    
}