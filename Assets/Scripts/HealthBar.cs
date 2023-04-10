using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    private Slider Slider;
    // Start is called before the first frame update
    void Start()
    {
        Slider = GetComponent<Slider>();
        Slider.maxValue = 100;
        Slider.value = 100;
        Slider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetHealth(int Health)
    {
       Slider.value=Health;

    }
}
