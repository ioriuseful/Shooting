using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    [SerializeField]
    private float interval = 5f;
    [SerializeField]
    private float tmpTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpTime += Time.deltaTime;
        if (tmpTime >= interval)
        {
            tmpTime = 0;
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }  
}
