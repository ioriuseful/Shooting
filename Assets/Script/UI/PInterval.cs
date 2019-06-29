using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PInterval : MonoBehaviour
{
    public Slider IntervalSlider;

    public float recast;

    public float re;

    GameObject player;
    public PlayerMove mov;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mov = player.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        recast = mov.Reget();
        re = mov.Rebar();
        if (recast == 0)
        {
            IntervalSlider.value = re;
        }
        else
        {
            IntervalSlider.value = re - re + recast;
        }
    }
}
