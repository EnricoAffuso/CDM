using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (Rigidbody2D))]
public class Movimenti : MonoBehaviour
{

    Rigidbody2D body;
    Animator anim;
    Vector3 checkPoint;

    //Variabili Migliorabili
    [SerializeField]
    float speed = 5;
    [SerializeField]
    float jump = 2f;

    bool staSaltando = false;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movimenti();
        salto();
    }

    void movimenti()
    {
        float movimentoOrizzontale = Input.GetAxis("Horizontal");
        Vector2 direzione = new Vector2(0, 0);

        if(movimentoOrizzontale != 0)
        {
            direzione.x = movimentoOrizzontale; 
        }
        transform.Translate(direzione * (speed * Time.deltaTime));
    
        if(direzione.x >= 0)
        {
            body.transform.localScale = new Vector3(0.1f, 0.1f, 1);
        }
        else
        {
            body.transform.localScale = new Vector3(-0.1f, 0.1f, 1);
        }

        anim.SetFloat("isMoving", Mathf.Abs(movimentoOrizzontale));
        if (Input.GetKey(KeyCode.P))
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(167,12);
        }
    }


    void salto()
    {
        float saltoVerticale = Input.GetAxis("Jump");
        if (staSaltando)
        {
            if (body.velocity.y == 0)
            {
                staSaltando = false;
            }
        }
        else
        {
            if (saltoVerticale > 0)
            {
                body.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                staSaltando = true;
            }
        }
    }
}
