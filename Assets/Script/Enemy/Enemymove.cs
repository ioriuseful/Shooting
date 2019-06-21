using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    public Vector3 velocity;
    public float length;
    float lengthlimit;
    Vector3 enemyposition;
    Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Transform>();
        enemyposition = enemy.position;
        lengthlimit = length;
    }

    // Update is called once per frame
    void Update()
    {
        length--;
        if (length <= 0)
        {
            velocity *= -1;
            length = lengthlimit;
        }
        enemy.position += velocity;
    }
}
