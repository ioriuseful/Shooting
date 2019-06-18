using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;
    Vector3 velocity = new Vector3(0.1f, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GameObject.FindGameObjectWithTag("Player").transform;//
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.MovePosition(transform.position + new Vector3(-0.1f, 0, 0));
        if (transform.position.x >= 5) 
        {
            velocity.x = -0.1f;
           // rigidbody.MovePosition(transform.position + velocity);
        }
        if (transform.position.x <= -5)
        {
            velocity.x = 0.1f;
            }
        //else
        //{
        //    rigidbody.MovePosition(transform.position + new Vector3(-0.1f, 0, 0));
        //}
        rigidbody.MovePosition(transform.position + velocity);

    }
}
