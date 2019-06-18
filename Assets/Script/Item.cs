using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameObject player;
    PlayerHp playerHp;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerHp = player.GetComponent<PlayerHp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OncolisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Player")
        {
            Destroy(gameObject);
        }
    }
}
