using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBheaviour : MonoBehaviour
{

    Transform Player;

    [SerializeField]
    float z_offset = -100;
    [SerializeField]
    float y_offset = 2;

    [SerializeField]
    float smooth = 0.1f;

    Vector3 movimento = Vector3.zero;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        if(Player != null)
        {
            Vector3 posizione = new Vector3(Player.position.x, Player.position.y + y_offset, Player.position.z + z_offset);
            transform.position = Vector3.SmoothDamp(transform.position, posizione, ref movimento, smooth);
        }
    }
}
