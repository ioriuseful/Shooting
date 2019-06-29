using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossbulletmove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 velocity;
    public float speed = 0.3f;
    Transform bullet;
    Rigidbody rigidbody;
    Vector3 bulletposition;
    float bossangle;
    float deathCount = 0f;
    Transform bosstrans;

    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        bosstrans = GameObject.FindGameObjectWithTag("Boss").transform;
        bossangle = bosstrans.eulerAngles.y * (Mathf.PI / 180);
        velocity = new Vector3(Mathf.Sin(bossangle), 0, Mathf.Cos(bossangle)) * speed;

       // velocity = new Vector3(Mathf.Cos(bossangle), Mathf.Sin(bossangle), 0) * speed;
        bullet = GetComponent<Transform>();
        bulletposition = bullet.position;
        //velocity = (playerposition - bulletposition).normalized * 0.3f;//正規化して直線の速度に
    }
  

    // Update is called once per frame
    void Update()
    {


        bullet.position = (bulletposition += velocity);
        deathCount++;
        if (deathCount >= 600)
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}

