using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class projectile : MonoBehaviour
{
    [SerializeField] float damage = 1f;
    [SerializeField] public string SourceTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(!other.gameObject.CompareTag(SourceTag)) {
            Entity entity = other.GetComponent<Entity>();
            if(entity) {
                entity.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
    
}

