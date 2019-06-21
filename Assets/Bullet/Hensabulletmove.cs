using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hensabulletmove : MonoBehaviour
{
    // Start is called before the first frame update
    
    Vector3 hensavelocity;
    Vector3 playervelocity;
    float time;
    //public float x, y, z;

    public float speed = 0.3f;
    Transform hensabullet;
    GameObject player;
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


        rigidbody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerposition = player.GetComponent<Transform>().position;
        playervelocity = player.GetComponent<PlayerMove>().returnmovement();
        //player.position;

        hensabullet = GetComponent<Transform>();
        bulletposition = hensabullet.position;
        time = Vector3.Magnitude(playerposition - bulletposition)
            / Vector3.Magnitude((playerposition - bulletposition).normalized);
        hensavelocity = (playerposition + (playervelocity *( time+15)) - bulletposition).normalized;
        //hensavelocity = (playerposition - bulletposition + hensavelocity).normalized * speed;//正規化して直線の速度に
    }
    private void Awake()
    {

        rigidbody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerposition = player.GetComponent<Transform>().position;
        playervelocity = player.GetComponent<PlayerMove>().returnmovement();
        //player.position;

        hensabullet = GetComponent<Transform>();
        bulletposition = hensabullet.position;
        time = Vector3.Magnitude(playerposition - bulletposition)
            / Vector3.Magnitude((playerposition - bulletposition).normalized);
        hensavelocity = ((playerposition + (playervelocity * (time))) - bulletposition).normalized*2;

    }

    // Update is called once per frame
    void Update()
    {

        hensabullet.position = (hensabullet.position += hensavelocity * speed);
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


