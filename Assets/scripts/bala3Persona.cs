using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala3Persona : MonoBehaviour
{
    public GameObject gamecont;
    public GameController gameController;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamecont = GameObject.Find("GameControler");
        gameController = gamecont.GetComponent<GameController>();
    }

    void FixedUpdate()
    {
        rb.transform.Translate(new Vector2(0f, 3) * Time.deltaTime);
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameController.RestarVida();
            Destroy(this.gameObject);
        }
        if(col.gameObject.tag == "abajo")
        {
            Destroy(this.gameObject);
        }
    }  
}
