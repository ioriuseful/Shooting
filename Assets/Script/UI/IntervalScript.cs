using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntervalScript : MonoBehaviour
{
    public Slider IntervalSlider;

    public float recast;

    public float re;

    public BomScript b;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        b = player.GetComponent<BomScript>();
    }

    // Update is called once per frame
    void Update()
    {
        recast = b.Reget();
        re = b.Rebar();
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
