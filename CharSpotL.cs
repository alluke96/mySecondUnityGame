using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpotL : MonoBehaviour
{
    public Transform targetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(targetToFollow.position.x, 5, targetToFollow.position.z -3);
        this.transform.rotation = Quaternion.Euler(new Vector3(targetToFollow.rotation.x, targetToFollow.rotation.y, targetToFollow.rotation.z));
        //Lembrar de analisar a rotação para q a luz do personagem não rotacione caso o personagem caia
    }
}
