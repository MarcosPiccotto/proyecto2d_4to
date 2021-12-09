using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private bool active;
    private Canvas canvas;
    public GameObject GameControl;
    public GameController GameController;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            canvas.enabled = active;
            //utilizamos un operador uternario/ternario le pregunta a "active" si esta pausa
            //en ese caso lo ponemos en 0 en caso contrario ":" lo ponemos en 1 (tiempo normal)
            Time.timeScale = (active) ? 0 : 1f;
            if(active == true)
            {
                GameController.fuenteAudio.Stop();
            }
            else
            {
                GameController.fuenteAudio.Play();
            }
        }
    }

    public void VolverJuego()
    {
        canvas.enabled = false;
        Time.timeScale = 1f;
        GameController.fuenteAudio.Play();
    }

    public void SalirMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
