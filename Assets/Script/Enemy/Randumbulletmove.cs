using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randumbulletmove : MonoBehaviour
{
    // Start is called before the first frame update
    Random rnd;
    Vector3 rndvector;
    Vector3 velocity;
    public float x, y, z;

    public float speed = 0.3f;
    Transform randombullet;
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

        rndvector = new Vector3(x * Random.Range(0, 3), 0, z * Random.Range(0, 3));
        rigidbody = GetComponent<Rigidbody>();
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        randombullet = GetComponent<Transform>();
        bulletposition = randombullet.position;
        velocity = (playerposition - bulletposition + rndvector).normalized * speed;//正規化して直線の速度に
    }
    private void Awake()
    {
        playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        randombullet = GetComponent<Transform>();
        bulletposition = randombullet.position;
        velocity = (playerposition - bulletposition + rndvector).normalized * speed;//正規化して直線の速度に

    }

    // Update is called once per frame
    void Update()
    {

        randombullet.position = (bulletposition += velocity);
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

