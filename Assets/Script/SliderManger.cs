using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManger : MonoBehaviour
{
    public Slider healthSilider;//HPbarUI
    private int hpbar;
    PlayerHp ph;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SliderUp()
    {
        hpbar = ph.GetHp();
        healthSilider.value = hpbar;
    }
}
