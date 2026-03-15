using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{
    public Health playerHealth;
    public Image FillImage;
    public Slider Slider;

    private void Awake()
    {
        Slider = GetComponent<Slider>();
    }

    private void Update()
    {
        Slider.value = playerHealth.currentHealth;
    }
}
