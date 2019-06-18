using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public Vector3 movement;
    Rigidbody playerRigidbody;
<<<<<<< HEAD

    Plane plane = new Plane();
    float distance = 0;
    //int floorMask;
    //float camRayLength = 100f;


=======
>>>>>>> 9e5cefa51671b1c8f95f91fd4205141f438e5743
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
<<<<<<< HEAD

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);
        if(plane.Raycast(ray,out distance))
        {
            var lookPoint = ray.GetPoint(distance);
            transform.LookAt(lookPoint);
        }

        //var screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //var direction = Input.mousePosition - screenPos;

        //var angle = GetAim(Vector3.zero, direction);
        //transform.SetLocalEulerAnglesY(-angle + 90);


=======
       
>>>>>>> 9e5cefa51671b1c8f95f91fd4205141f438e5743
>>>>>>> 5a7f381d21d2c9ead2691c2660d8271d7a2a6639
    }
    void PlayerMovement(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }
<<<<<<< HEAD
    public Vector3 returnmovement()
    {
        return movement;
    }
=======
<<<<<<< HEAD

    //void Turning()
    //{
    //    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit floorHit;
    //    if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
    //    {
    //        Vector3 playerToMouse = floorHit.point - transform.position;
    //        playerToMouse.y = 0f;
    //        Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
    //        playerRigidbody.MoveRotation(newRotation);
    //    }
    //}


    public float GetAim(Vector2 from, Vector2 to)
    {
        float dx = to.x - from.x;
        float dy = to.y - from.y;
        float rad = Mathf.Atan2(dy,dx);

        return rad * Mathf.Rad2Deg;
    }
=======
>>>>>>> 9e5cefa51671b1c8f95f91fd4205141f438e5743
>>>>>>> 5a7f381d21d2c9ead2691c2660d8271d7a2a6639
}
