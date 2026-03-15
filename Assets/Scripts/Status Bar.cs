using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{
    public Health playerHealth;
    public Image fillImage;
    public Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        slider.value = playerHealth.currentHealth;
    }
}
