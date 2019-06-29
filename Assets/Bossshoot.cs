using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossshoot : MonoBehaviour
{
    public GameObject targetplayer;
    public GameObject[] nozuls;//銃口
    public GameObject[] bossbullet;//弾の種類
    float shoottime;//撃つ間隔
    public float limitshoottime;
    public enum AI
    {
        Normal,
        Renda,
    };
   AI currentAI;


    Transform playertrans;
    // Start is called before the first frame update
    void Start()
    {
        playertrans = targetplayer.transform;
        shoottime = limitshoottime;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shot()
    {

        shoottime--;
        if (currentAI == AI.Normal)
        {
            if (shoottime <= 0)
            {
                for (int i = 0; i < nozuls.Length; i++)
                {
                    Instantiate(bossbullet[0], nozuls[i].transform.position, nozuls[i].transform.rotation);
                }
                shoottime = limitshoottime;
            }
        }
        else if (currentAI == AI.Renda)
        {
            if (shoottime <= 0)
            {
                for (int i = 0; i < nozuls.Length; i++)
                {
                    Instantiate(bossbullet[1], nozuls[i].transform.position, nozuls[i].transform.rotation);
                }
                shoottime = limitshoottime / 8;
            }
        }
        
    }
    public void ChangeAI(AI ai)
    {
        currentAI = ai;
    }
    public AI returnAI()
    {
        return currentAI;
    }
}