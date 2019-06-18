using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Image image;
    GameObject player;
    PlayerHp playerHp;


    int del;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHp = player.GetComponent<PlayerHp>();

    }

    // Update is called once per frame
    void Update()
    {
        del = playerHp.Getstock();
        if(del<3)
        {
            Destroy(GameObject.Find("Im"));
        }
        if(del<2)
        {
            Destroy(GameObject.Find("Im1"));
        }
        if(del<1)
        {
            Destroy(GameObject.Find("Im2"));
        }
        
    }
}
