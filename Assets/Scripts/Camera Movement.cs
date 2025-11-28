using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//moves the camera based on the player's position
public class CameraMovement : MonoBehaviour 
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x is >= 4.5f and <= 46f)
        {
            transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        }
    }
}
