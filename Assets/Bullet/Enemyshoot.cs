using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{
    // Start is called before the first frame update
    Ray shootRay;
    RaycastHit shootHit;
    public GameObject bullet;
    int shootableMask;
    Transform enemyTrans;
    LineRenderer line;
    Light shootLight;
    float bulletspawn;
    public Enemyshoot()
    {
        bulletspawn = 90;
    }
    void Start()
    {
        // line = GetComponent<LineRenderer>();

        //  shootLight = GetComponent<Light>();
        enemyTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletspawn--;
        if (bulletspawn <= 0)
        {
            bulletspawn = 90;
            Instantiate(bullet, enemyTrans.position,enemyTrans.rotation);
           
        }
    }
}
