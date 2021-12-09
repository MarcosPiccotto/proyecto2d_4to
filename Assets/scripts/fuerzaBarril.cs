using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerzaBarril : MonoBehaviour
{
    
    private float speed = 3f;
    private float timer;
    private float posY;
    // Start is called before the first frame update
    void Start()
    {

        //timer = Time.time + 2f;
        //posY = Mathf.Clamp(transform.position.y, 1f, 4f);
        //transform.position = new Vector2(transform.position.x,posY);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, 2f) * Time.deltaTime);
        //posY = Mathf.Clamp(transform.position.y, 1f, 4f);
        //transform.position = new Vector2(transform.position.x,posY);
    }

    void OnBecameInvisible() {
        //if(timer == 2f)
        //{
            //Destroy(gameObject);
        //}
    }
}
