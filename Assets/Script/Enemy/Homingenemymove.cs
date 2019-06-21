using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homingenemymove : MonoBehaviour
{
    Transform homingenemy;
    Rigidbody rigidbody;
    Transform player;
    
    Vector3 velocity;
    public float speed;
    float interval;
    float attacktime;
    public float limitattacktime;
    public float limitinterval;
    // Start is called before the first frame update
    void Start()
    {
        homingenemy = transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rigidbody = GetComponent<Rigidbody>();
        //speed = 3f;
        //limitinterval = 60f;
        //limitattacktime = 90f;
        interval = limitinterval;
        attacktime = limitattacktime;
    }

    // Update is called once per frame
    void Update()
    {
        if (attacktime >= 0)
        {
            attacktime--;
            homingenemy.position += velocity;
        }
        else
        {
            velocity = (player.position - homingenemy.position).normalized * speed;
            interval--;
            if (interval <= 0)
            {
                attacktime = limitattacktime;
                interval = limitinterval;
            }
        }
    }
}
