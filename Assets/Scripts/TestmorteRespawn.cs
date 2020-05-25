using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestmorteRespawn : MonoBehaviour
{
    public Vector3 checkPoint;
    
    int nMorti;

    void Update()
    {
        Altezza();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody != null && collision.rigidbody.tag == "Affungo" || collision.rigidbody != null && collision.rigidbody.tag == "Trappola")
        {
            gameObject.transform.position = checkPoint;
            nMorti++;
        }
    }

    void Altezza()
    {
        if (gameObject.transform.position.y < 0)
        {
            gameObject.transform.position = checkPoint;
        }
    }
}
