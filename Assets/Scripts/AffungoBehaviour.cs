using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffungoBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed = 4.0f;
    [SerializeField]
    GameObject limiteSinistro;
    [SerializeField]
    GameObject limiteDestro;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject == limiteSinistro || collider.gameObject == limiteDestro) 
        {
            speed *= -1;
        }
    }
    void Update()
    {
        Vector3 moveVector = Vector3.left;
        transform.position += moveVector * speed * Time.deltaTime;
    }
}
