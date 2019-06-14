using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    private int hpbar;//HPバー
    public int stock;//残機
    public Slider healthSilider;//HPbarUI


    bool isDead;

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
<<<<<<< HEAD
            if(stock>=0)
            {
                hpbar = 100;
            }
=======
            hpbar = 100;
            healthSilider.value = hpbar;

            // UnityEditor.EditorApplication.isPlaying = false;
>>>>>>> df249669d7dd23ef43d175c9117e1d542f800cfa
        }
        if(stock <0)
        {
            Death();
        }
    }

    void OnCollisionEnter(Collision enemy)
    {
        if(enemy.gameObject.tag == "Ene1")
        {
            hpbar -= 20;
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
}
