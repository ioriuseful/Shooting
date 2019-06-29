using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public Vector3 movement;
    Rigidbody playerRigidbody;

    Plane plane = new Plane();
    float distance = 0;
    //int floorMask;
    //float camRayLength = 100f;
    bool avoid = false;
    int avoidcheck = 1;
    float speedReset;

    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject playerCube;

    //連続使用制限
    [SerializeField]
    private float interval = 3f;
    [SerializeField]
    private float tmpTime = 0;

    bool re;

    // Start is called before the first frame update
    void Start()
    {   
        playerRigidbody = GetComponent<Rigidbody>();
        speedReset = speed;
        re = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale==0f)
        {
            return;
        }
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        PlayerMovement(h, v);

        if (avoid)
        {
            speed *= 1.2f;
            Invoke("Asd", 0.2f);
            Invoke("LayerReset", 0.4f);

        }
        else
        {
            speed = speedReset;
        }
        if (re)
        {
            tmpTime += Time.deltaTime;
            if (tmpTime >= interval)
            {
                tmpTime = 0;
                re = false;
            }
        }
        if (!re)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SetLayer(14);
                avoid = true;
                re = true;
            }
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);
        if (plane.Raycast(ray, out distance))
        {
            var lookPoint = ray.GetPoint(distance);
            transform.LookAt(lookPoint);
        }

    }
    void PlayerMovement(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    public Vector3 returnmovement()
    {
        return movement;
    }


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

    public void Mup()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        PlayerMovement(h, v);

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);
        if (plane.Raycast(ray, out distance))
        {
            var lookPoint = ray.GetPoint(distance);
            transform.LookAt(lookPoint);
        }
    }

    void Asd()
    {
        avoid = false;
    }

    void LayerReset()
    {
        SetLayer(8);
    }
    public void SetLayer(int layerNumber)
    {
        playerObject.layer = layerNumber;
        playerCube.layer = layerNumber;
    }
    public float Reget()
    {
        return tmpTime;
    }
    public float Rebar()
    {
        return interval;
    }
}
