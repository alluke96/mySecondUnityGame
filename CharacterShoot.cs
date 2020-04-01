using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterShoot : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject ammunition;
    public int ammoQuantity = 30;
    public Text UIAmmoText;
    private bool canShoot = true;
    public float delayInSeconds;
    public AudioSource gunShot;
    public AudioClip gunshots, empty;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UIAmmoText.text = ammoQuantity + "/ 30";

        if (Input.GetMouseButton(0) && ammoQuantity != 0 && canShoot == true) 
            //Lembrar de colocar para a bala rotacionar em y dependendo da direção do mouse
        {
            gunShot.PlayOneShot(gunshots);
            ammoQuantity--;
            GameObject tempObject;
            tempObject = Instantiate(ammunition);
            tempObject.transform.position = this.transform.position;
            tempObject.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            canShoot = false;
            StartCoroutine(ShootDelay());
        }

        if (Input.GetMouseButton(0) && ammoQuantity == 0 && canShoot == true)
        {
            gunShot.PlayOneShot(empty);
            canShoot = false;
            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        canShoot = true;
    }
}