using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    private int hpbar;//HPバー
    public int stock;//残機

    // Start is called before the first frame update
    void Start()
    {
        hpbar = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hpbar);
        if(hpbar<=0)
        {
            stock -= 1;
            hpbar = 50;

           // UnityEditor.EditorApplication.isPlaying = false;
        }
        if(stock ==0)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    void OnCollisionEnter(Collision enemy)
    {
        if(enemy.gameObject.tag == "Ene1")
        {
            hpbar -= 20; 
        }
    }
}
