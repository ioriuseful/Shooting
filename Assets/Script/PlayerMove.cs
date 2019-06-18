using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Vector3 movement;
    Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {   
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        PlayerMovement(h, v);
<<<<<<< HEAD
=======
       
>>>>>>> 0601003048537bfbbd9798aef6236f1b62d8837f
    }
    void PlayerMovement(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }
}
