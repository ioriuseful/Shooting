using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    Vector3 movement;
    Rigidbody playerRigidbody;
<<<<<<< HEAD
=======
    int floorMask;
    float camRayLength = 100f;
>>>>>>> 3e381c94ae779846431019d9f761440d17f2cffa
    // Start is called before the first frame update
    void Start()
    {   
        playerRigidbody = GetComponent<Rigidbody>();
<<<<<<< HEAD
=======
        floorMask = LayerMask.GetMask("Floor");
>>>>>>> 3e381c94ae779846431019d9f761440d17f2cffa
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        PlayerMovement(h, v);
<<<<<<< HEAD
=======
        Turning();
>>>>>>> 3e381c94ae779846431019d9f761440d17f2cffa
    }
    void PlayerMovement(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }
<<<<<<< HEAD
=======
    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigidbody.MoveRotation(newRotation);
        }
    }
>>>>>>> 3e381c94ae779846431019d9f761440d17f2cffa
}
