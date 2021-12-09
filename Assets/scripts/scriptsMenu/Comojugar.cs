using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comojugar : MonoBehaviour
{
    private bool active;
    private Canvas canvas;
    public GameObject GameControl;
    public GameController GameController;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
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
}
