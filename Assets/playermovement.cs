using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MEOW");
    }
    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.linearVelocity = dir * 10;
        

    } 
    // Update is called once per frame

    void Update()
    {
        
    }
}
