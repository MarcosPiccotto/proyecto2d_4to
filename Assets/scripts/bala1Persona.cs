using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala1Persona : MonoBehaviour
{

    
    private Rigidbody2D rb;
    public GameObject gamecont;
    public GameController gameController;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamecont = GameObject.Find("GameControler");
        gameController = gamecont.GetComponent<GameController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.transform.Translate(new Vector2(0f, 2) * Time.deltaTime);
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
