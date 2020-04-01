using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemigoDie : MonoBehaviour
{
    public AudioSource enemigo;
    public AudioClip die;

    private int enemigoLife = 100;

    // Update is called once per frame
    void Update()
    {
        if (enemigoLife <= 0)
        {
            enemigo.PlayOneShot(die);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ammo"))
        {
            enemigoLife -= 10;
            Debug.Log(enemigoLife);
        }
    }
}
