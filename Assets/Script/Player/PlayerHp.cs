﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public int hpbar;//HPバー
    public int stock;//残機

    public Slider healthSilider;//HPbarUI



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
        


                Debug.Log(hpbar);
                if (hpbar < 1)
                {
                    stock -= 1;
                    hpbar = 100;
                    healthSilider.value = hpbar;
                    Debug.Log("yabapo");
                    // UnityEditor.EditorApplication.isPlaying = false;

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
                    healthSilider.value = hpbar;
        }
        if(enemy.gameObject.tag=="Item")
        {

            hpbar += 20;
            healthSilider.value = hpbar;
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