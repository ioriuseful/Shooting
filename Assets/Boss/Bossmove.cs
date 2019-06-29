using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossmove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbody;
    WarpManager warplist;
    public float limitwarptime;//ワープの間隔
    float warptime;
    Vector3 warpposition;
    float random;//ランダム数値の保存
    Bossshoot bossshoot;
    float movetime;
    float angle;
    public GameObject rotationtarget;

    [SerializeField]
    private float interval = 3f;
    [SerializeField]
    private float tmpTime = 0;

    private bool en;
    void Start()
    {
       // rigidbody = GetComponent<Rigidbody>();
       // rigidbody.centerOfMass = new Vector3(1, 0, 1);
        angle = 0;
        movetime = 600f;
        warptime = limitwarptime;
        warplist = GetComponent<WarpManager>();
        bossshoot = gameObject.GetComponent<Bossshoot>();

        en = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (en)
        {
            tmpTime += Time.deltaTime;
            if (tmpTime >= interval)
            {
                tmpTime = 0;
                en = false;
            }
            return;
        }
        movetime--;

        if (bossshoot.returnAI() == Bossshoot.AI.Normal)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation
              (rotationtarget.transform.position - transform.position), 0.1f);

            if (movetime >= 400)
            {
                Move();
            }
            if (movetime < 400 && movetime >= 0)
            {
                bossshoot.Shot();
            }
            if (movetime < 0)
            {
                bossshoot.ChangeAI(Bossshoot.AI.Renda);
                movetime = 600;
            }
        }
        else
        {
            movetime--;
            if (movetime >= 0)
            {
                Move();
                bossshoot.Shot();
            }
            if (movetime < 0)
            {
                bossshoot.ChangeAI(Bossshoot.AI.Normal);
                movetime = 600;
            }
        }
    }
    public void Move()
    {
        warptime--;
        if (bossshoot.returnAI() == Bossshoot.AI.Normal)
        {
            if (warptime <= 0)
            {
                random = Random.Range(0, warplist.warptiles.Length);
                transform.position = warplist.warptiles[(int)random].transform.position;


                warptime = limitwarptime;
            }
        }
        else if (bossshoot.returnAI() == Bossshoot.AI.Renda)
        {
            angle = 3f;
            transform.position = Vector3.zero;
          
            transform.Rotate(new Vector3(0, angle, 0));
        }

    }
}
