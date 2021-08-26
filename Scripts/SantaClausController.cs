using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaClausController : MonoBehaviour
{
    // Start is called before the first frame update
   
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    void Start()
    {
        Debug.Log("Iniciando Game Object");
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
           

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.right;
        }
    }
}
