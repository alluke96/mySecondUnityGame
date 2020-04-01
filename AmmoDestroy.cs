using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            //Adicionar variavel de vida do zumbi
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
