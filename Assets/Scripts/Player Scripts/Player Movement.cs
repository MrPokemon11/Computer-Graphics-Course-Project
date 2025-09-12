using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool canJump = true;
    private bool hasDied = false;

    private float MoveSpeed = 5f;
    float JumpForce = 13f;
    
    Rigidbody rb;
    
    PlayerManager pm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move left
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * (MoveSpeed * Time.deltaTime);
            if (transform.position.x <= -4)
            {
                transform.position = new Vector3(-4, transform.position.y, transform.position.z);
            }
        } 
        //Move Right
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * (MoveSpeed * Time.deltaTime);
        }
        //Jump
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && canJump == true)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            canJump = false;
        }

        if (transform.position.y >= 9.8)
        {
            hasDied = true;
            pm.playerDie();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Wall")
        {
            canJump = true;
        }

        if (collision.gameObject.tag == "Finish" && !hasDied)
        {
            pm.playerWin();
        }
    }
}
