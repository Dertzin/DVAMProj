using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using static UnityEditor.PlayerSettings;

public class HammerMovement : MonoBehaviour
{
    private float rotationSpeed;
   
    private float limit = 360f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time +  rotationSpeed);
        transform.localRotation = Quaternion.Euler(0, angle, -90f);
    }
}
