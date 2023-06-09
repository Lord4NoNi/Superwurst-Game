using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healtbar : MonoBehaviour
{

    
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(float health)
	{
        slider.value = health;
        

        fill.color = gradient.Evaluate(slider.normalizedValue);
	}

    public void SetMaxHealth(float health)
	{
        slider.maxValue = health;
        
        gradient.Evaluate(slider.normalizedValue);
	}
}
