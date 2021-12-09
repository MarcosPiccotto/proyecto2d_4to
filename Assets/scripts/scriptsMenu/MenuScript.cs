using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    private AudioSource reproductor;
    public AudioClip clipInicio;

    void Start()
    {
        reproductor = GetComponent<AudioSource>();
        reproductor.clip = clipInicio;
        reproductor.Play();
    }

    public void jugarJuego()
    {

        SceneManager.LoadScene("JuegoPrincipal");
    }

    public void salirJuego()
    {
        Application.Quit();
    }

    public void comoJugar()
    {
        SceneManager.LoadScene("ComoJugar");
    }
}
