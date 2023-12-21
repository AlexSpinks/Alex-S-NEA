using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{
    public Health playerHealth;
    public Image FillImage;
    public Slider Slider;
    // Start is called before the first frame update
    void Awake()
    {
        Slider = GetComponent<Slider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float fillvalue = playerHealth.currentHealth;
        Slider.value = playerHealth.currentHealth;
    }
}
