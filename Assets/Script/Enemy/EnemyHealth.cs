using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public float limithp;//
    float currenthp;//
    public GameObject pbullet;
    float damage;
    public float raydamage;

    void Start()
    {
        currenthp = limithp;
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Damage()
    {
        currenthp -= damage;
    }


    //追加
    public void RayDamage()
    { 
        currenthp -= raydamage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Pbullet"))
        {
            damage = collision.gameObject.GetComponent<PbulletScript>().returndamage();
            Damage();
        }
    }
}
