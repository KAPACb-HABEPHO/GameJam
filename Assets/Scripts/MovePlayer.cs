using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private Transform _transform;
    private Vector3 _playerPos;
    private float _velcotiy= 1.5f;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += Vector3.up * _velcotiy * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * _velcotiy * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
         
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.left * _velcotiy * Time.deltaTime;
        }
    }
}
