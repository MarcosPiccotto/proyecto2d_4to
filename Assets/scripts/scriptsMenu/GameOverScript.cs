using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private AudioSource reproductor;
    public AudioClip clipInicio;
    // Start is called before the first frame update
    void Start()
    {
        reproductor = GetComponent<AudioSource>();
        reproductor.clip = clipInicio;
        reproductor.Play();
    }

    public void jugarAgain()
    {
        SceneManager.LoadScene("JuegoPrincipal");
    }

    public void volverMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
