using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        hpbar = 100;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //Debug.Log(hpbar);
        if(hpbar<=0)
        {
            stock -= 1;
            hpbar = 100;

           // UnityEditor.EditorApplication.isPlaying = false;
=======
        Debug.Log(hpbar);
        if(hpbar<1)
        {
            stock -= 1;
            hpbar = 100;
            healthSilider.value = hpbar;

            // UnityEditor.EditorApplication.isPlaying = false;
>>>>>>> 9e5cefa51671b1c8f95f91fd4205141f438e5743
        }
        if(stock <=0)
        {
            Death();
        }
        if(hpbar>100)
        {
            hpbar = 100;
        }
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
            hpbar += 40;
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
