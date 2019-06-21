using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public int hpbar;//HPバー
    public int stock;//残機
    bool isDead;
    SliderManger slM;

    // Start is called before the first frame update
    void Start()
    {
        hpbar = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (hpbar <= 0)
        {
            stock -= 1;
            hpbar = 100;           // UnityEditor.EditorApplication.isPlaying = false;
        }
        if (stock <= 0)
        {
            Death();
        }
        if (hpbar > 100)
        {
            hpbar = 100;
        }
        slM.SliderUp();
    }

    void OnCollisionEnter(Collision enemy)
    {
        if(enemy.gameObject.tag == "Ene1")
        {
            hpbar -= 20;   
        }
        if(enemy.gameObject.tag=="Item")
        {
            hpbar += 20;
        }
    }
    void Death()
    {
        isDead = true;
        //Destroy(gameObject);
        //
        Invoke("Shift", 3);
    }
    void Shift()
    {
        SceneManager.LoadScene("GameOver");
    }

    public int Getstock()
    {
        return stock;
    }
    public int GetHp()
    {
        return hpbar;
    }
}
