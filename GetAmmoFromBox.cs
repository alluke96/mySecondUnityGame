using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAmmoFromBox : MonoBehaviour
{
    public GameObject tampa;
    //private static GameObject municao = GameObject.Find("Shooter");
    public CharacterShoot _characterShoot;

    private bool isPegado;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isPegado)
        {
            Destroy(tampa); // QUE TAMPA?
            GetAmmo(30);
            isPegado = true;
        }
        
    }

    void GetAmmo(int ammo)
    {
        _characterShoot.ammoQuantity = ammo;
    }
}
