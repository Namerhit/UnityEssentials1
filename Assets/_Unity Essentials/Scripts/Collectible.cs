using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject onCollectEffect;
    public float rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
