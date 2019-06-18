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

    // Start is called before the first frame update
    void Start()
    {
        des = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            CutinStart();
            Debug.Log("panpa-su");
            
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
        catinInstance = GameObject.Instantiate(catinPrefab) as GameObject;
        transform.parent = GameObject.Find("HUDCanvas 1").transform;
        des = true;
    }

    public void Stop()
    {
        Destroy(catinInstance);
    }
}
