using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PbulletScript : MonoBehaviour
{
    //Vector3 velocity;
    //public int speed;
    //Rigidbody rb;
    //private Vector3 position;
    //Vector3 pbulletposition;
    //Transform pbullet;

    public GameObject player;
    public GameObject pbullet;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject pbullet = GameObject.Instantiate(Pbullet) as GameObject;
        //position = Input.mousePosition;
        //rb = GetComponent<Rigidbody>();
        //rb.velocity = transform.up.normalized * speed + position;
        //pbullet = GetComponent<Transform>();
        //pbulletposition = pbullet.position;
        //velocity = pbulletposition.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーとPbulletの距離を測って35になったら弾を消す
        Vector3 Apos = player.transform.position;
        Vector3 Bpos = pbullet.transform.position;
        float dis = Vector3.Distance(Apos, Bpos);
        Debug.Log("Distance:" + dis);
        
        if(dis>35)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision enemy)
    {
        if (enemy.gameObject.tag == "Ene1")
        {
            Destroy(gameObject);
            //Debug.Log("aaaaa");
        }
        if (enemy.gameObject.tag == "Wall")
        {
            Debug.Log("aaaaaaawaaaaaaawwwwwwww");
            Destroy(gameObject);
        }

    }
    public float returndamage()
    {
        return damage;
    }
}
