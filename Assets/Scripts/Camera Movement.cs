using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
        if (transform.position.x <= 4.5f)
        {
            transform.position = new Vector3(4.5f, transform.position.y, transform.position.z);
        } else if (transform.position.x >= 46f)
        {
            transform.position = new Vector3(46f, transform.position.y, transform.position.z);
        }
    }
}
