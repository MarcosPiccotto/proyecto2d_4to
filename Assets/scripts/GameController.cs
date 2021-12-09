using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI puntosUI;
    public TextMeshProUGUI vidaUI;
    public TextMeshProUGUI municionUI;

    public AudioClip playerDisparo;
    public AudioClip golpeado;
    public AudioClip mejora;
    public AudioSource fuenteAudio;

    public GameObject goNaveMadre;
    public NaveMadre naveMadre;
    public GameObject goTanke;
    public movement tanke;
    public GameObject NaveMadre;
    
    public int vidas;
    public float puntos;
    public int municion;
    public int contHereJefe;
    public int vidaMas;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        goNaveMadre = GameObject.Find("NaveMadre");
        naveMadre = goNaveMadre.GetComponent<NaveMadre>();
        
        vidas = 3;
        vidaMas = 0;
        puntos = 0f;
        municion = 10;
        contHereJefe = 0;
        puntosUI.text = "$ " + puntos;
        vidaUI.text = "x " + vidas;
        municionUI.text = municion + "/" + 10;
    }
    public void ClipDisparo()
    {
        fuenteAudio.PlayOneShot(playerDisparo);
    }
    public void ActualizarPuntos()
    {
        puntos ++;
        contHereJefe++;
        Debug.Log("contJefe"+contHereJefe);
        puntosUI.text = "$ " + puntos;
        vidaMas ++;
        if(vidas < 3 && vidaMas <= 10)
        {
            vidas ++;
            vidaMas = 0;
        }
        
    }
    public void ActualizarPuntosBalas()
    {
        puntos += 0.5f;
        Debug.Log("puntos = " + puntos);
        puntosUI.text = "$ " + puntos;
        
    }

    public void RestarVida()
    {
        vidas--;
        vidaUI.text = "x " + vidas;
        fuenteAudio.PlayOneShot(golpeado);
        if(vidas == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void ActualizarMunicion()
    {
        municion--;
        municionUI.text = municion + "/" + 10;
    }
    public void MejoraSonido()
    {
        fuenteAudio.PlayOneShot(mejora);
    }
}
