using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    public GameObject gController;
    public GameController gameController;
    public Transform disparo;
    public GameObject bala;
    public GameObject goNaveMadre;
    public NaveMadre naveMadre;
    private Rigidbody2D rb;
    private float horizontal;

    private float timeRate;
    private float fireTime;
    public TextMeshProUGUI recargarText; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gController = GameObject.Find("GameControler");
        gameController = gController.GetComponent<GameController>();

        goNaveMadre = GameObject.Find("NaveMadre");
        naveMadre = goNaveMadre.GetComponent<NaveMadre>();

        gameController.municion = 10;   

        timeRate = 1.5f;
        fireTime = 0;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f,0f, -horizontal * 2f); 

        if(Input.GetKey("up"))
        {
            rb.transform.Translate(new Vector2(0f, -1.5f)*Time.deltaTime);
        }

        if(Input.GetKey("down"))
        {
            rb.transform.Translate(new Vector2(0f, 1.5f)*Time.deltaTime);
        }

        float posY = Mathf.Clamp(transform.position.y, -4.66f, -2.82f);
        transform.position = new Vector2(transform.position.x,posY);
    }

    void Update()
    {
        if(gameController.municion <= 10 && gameController.municion > 0)
        {
            if(Input.GetKeyDown(KeyCode.Space) && Time.time > timeRate + fireTime)
            {
                Instantiate(bala, disparo.position, disparo.rotation);
                fireTime = Time.time;
                gameController.ClipDisparo();
                gameController.ActualizarMunicion();
            }
        }
        if(gameController.municion < 1)
        {
            recargarText.text = " Recargar con R";
            if(Input.GetKeyDown(KeyCode.R))
            {
                gameController.municion = 11;
                recargarText.text = " ";
                gameController.ActualizarMunicion();
            }
        }
        if(gameController.contHereJefe >= 35)
        {
            SceneManager.LoadScene("victoria_royale");
        }
    }
}
