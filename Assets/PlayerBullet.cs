using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject Pbullet;
    public float speed = 500;
    public Transform muzzle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Shot();
        }

        //transform.Translate(0, 0, speed);
    }

    void Shot()
    {

        GameObject Pbullets = Instantiate(Pbullet) as GameObject;

        Vector3 force;

        force = this.gameObject.transform.forward * speed;

        Pbullets.GetComponent<Rigidbody>().AddForce(force);

        Pbullets.transform.position = muzzle.position;

        //GameObject pbullet = GameObject.Instantiate(Pbullet) as GameObject;
        //// pbullet.GetComponent<Rigidbody>().velocity = transform.up.normalized * speed;
        //Instantiate(pbullet, playerTrans.position, playerTrans.rotation);
        ////pbullet.transform.position = transform.position;
    }

    void OnCollisionEnter(Collision enemy)
    {
        if (enemy.gameObject.tag == "Ene1")
        {
            Destroy(gameObject);
            Debug.Log("aaaaa");
        }

    }
}
