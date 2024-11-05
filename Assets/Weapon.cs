using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        
    }
[SerializeField] GameObject projectilePreFab;
[SerializeField] float projectileSpeed;
[SerializeField] float shootingCooldown;
[SerializeField] float lastShotTime;
public void Shoot(Vector2 direction) {
    if(Time.time - lastShotTime > shootingCooldown) {

    GameObject projectile = Instantiate(projectilePreFab, transform.position, Quaternion.identity);
    projectile projectileScript = projectile.GetComponent<projectile>();
    projectileScript.SourceTag = gameObject.tag;
    projectile.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(direction.x, direction.y, 0) * projectileSpeed;
    lastShotTime = Time.time;
    }
}
}

    // Update is called once per frame


