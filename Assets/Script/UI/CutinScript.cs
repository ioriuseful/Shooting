using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutinScript : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject catinPrefab;
    //　ポーズUIのインスタンス
    private GameObject catinInstance;
    bool des;

    [SerializeField]
    private float interval = 4f;
    [SerializeField]
    private float tmpTime = 0;

    BomScript bom;
    int bcount;
    int tim=0;



    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        des = false;
        player = GameObject.FindGameObjectWithTag("Player");
        bom = player.GetComponent<BomScript>();
    }

    // Update is called once per frame
    void Update()
    {
        bcount = bom.GetBomStayt();

        if (bcount==1 && tim==0)
        {
            CutinStart();
            Debug.Log(bcount);
        }

        if(des)
        {
            tmpTime += Time.deltaTime;
            if (tmpTime >= interval)
            {
                Stop();
                tmpTime = 0;
                des = false;
            }         
        }


    }

    public void CutinStart()
    {
        catinInstance = Instantiate(catinPrefab) as GameObject;
        des = true;
        tim = 1;
    }

    public void Stop()
    {
        Destroy(catinInstance);
        tim = 0;
    }
    public float Reget()
    {
        return interval;
    }
}
