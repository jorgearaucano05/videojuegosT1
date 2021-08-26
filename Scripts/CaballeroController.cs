using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaballeroController : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocityX = 5;

    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;

   


    void Start()
    {
        Debug.Log("Iniciando Game Object");
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        animator.SetInteger("Estado", 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(velocityX,rb.velocity.y);
            sr.flipX = false;
            animator.SetInteger("Estado", 2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-velocityX, rb.velocity.y);
            sr.flipX = true;
            animator.SetInteger("Estado", 2);
        }
        
        if (Input.GetKey((KeyCode.RightArrow))&&(Input.GetKey(KeyCode.X)))
        {
            rb.velocity = Vector2.right*20;
            sr.flipX = false;
            animator.SetInteger("Estado", 1);
        }

        if (Input.GetKey((KeyCode.LeftArrow))&&(Input.GetKey(KeyCode.X)))
        {
            rb.velocity = Vector2.right * -20;
            sr.flipX = true;
            animator.SetInteger("Estado", 1);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * 35, ForceMode2D.Impulse);
            animator.SetInteger("Estado", 3);
        }
        
        if (Input.GetKeyUp(KeyCode.Z))
        {
           rb.velocity = Vector2.right * 20;
           sr.flipX = false;
           animator.SetInteger("Estado", 4);
        }

    }
}
