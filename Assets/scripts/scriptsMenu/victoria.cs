using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class victoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void jugarJuego()
    {
        SceneManager.LoadScene("JuegoPrincipal");
    }    
    public void salirJuego()
    {
        SceneManager.LoadScene("menu");
    }
}
