using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;
using UnityEngine;

public class RobotScripts : MonoBehaviour
{

    [SerializeField] private float move;

    void Start()
    {

    }
   
    void Update()
    {
        float hp = Input.GetAxis("Horisontal");
        transform.Translate(Vector2.left * move * hp* Time.deltaTime);
    }


}
