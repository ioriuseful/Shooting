using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homingbulletmove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 velocity;
    float homingtime;
    public float speed = 0.3f;
    Transform homingbullet;
    Rigidbody rigidbody;
    Vector3 bulletposition;
    Vector3 playerposition;
    float deathCount = 0f;
    //public BulletMove()
    //{
    //    rigidbody = GetComponent<Rigidbody>();
    //    playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
    //    bullet = GetComponent<Transform>();
    //    bulletposition = bullet.position;
    //    velocity = (playerposition - bulletposition).normalized * 0.3f;//正規化して直線の速度に
    //}

    void Start()
    {
        homingtime = 90;
        rigidbody = GetComponent<Rigidbody>();
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        homingbullet = GetComponent<Transform>();
        bulletposition = homingbullet.position;
        velocity = (playerposition - bulletposition).normalized * speed;//正規化して直線の速度に
    }
    private void Awake()
    {
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        homingbullet = GetComponent<Transform>();
        bulletposition = homingbullet.position;
        velocity = (playerposition - bulletposition).normalized * speed;//正規化して直線の速度に

    }

    // Update is called once per frame
    void Update()
    {
        homingtime--;
        if (homingtime >= 0)
        {
            playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
            velocity = (playerposition - bulletposition).normalized * speed;

        }


        homingbullet.position = (bulletposition += velocity);
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
