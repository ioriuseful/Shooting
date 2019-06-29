using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomScript : MonoBehaviour
{
    [SerializeField]
    //　プレハブ
    private GameObject BomPrefab;
    //　インスタンス
    private GameObject BomInstance;
    CutinScript cut;

    //連続使用制限
    [SerializeField]
    private float interval = 500f;
    [SerializeField]
    private float tmpTime = 0;

    bool bom;
    int b = 0;
    // Start is called before the first frame update
    void Start()
    {
        bom = false;
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            if (!bom)
            {
                Bom();
                b = 1;
                Debug.Log("押したよ");
            }
            else
            {
                return;
            }
        }
        else
        {
            if (bom)
            {
                b = 0;
            }
            else
            {
                return;
            }
        }
        if (bom)
        {
            tmpTime += Time.deltaTime;
            if (tmpTime >= interval)
            {
                tmpTime = 0;
                bom = false;
            }
        }
    }

    public void Bom()
    {
        BomInstance = GameObject.Instantiate(BomPrefab) as GameObject;
        Debug.Log("作成");
        bom = true;
        Invoke("Del", 3f);
    }

    void Del()
    {
        b = 0;
        Debug.Log(b);
        Destroy(BomInstance);
    }
    public int GetBomStayt()
    {
        return b;
    }

    public float Reget()
    {
        return tmpTime;
    }
    public float Rebar()
    {
        return interval;
    }
}
