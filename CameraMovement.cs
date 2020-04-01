using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = targetToFollow.position;
        this.transform.position = new Vector3(targetToFollow.position.x, (targetToFollow.transform.position.y + 15), targetToFollow.position.z); // Nao grudar a camera na bola
    }
}