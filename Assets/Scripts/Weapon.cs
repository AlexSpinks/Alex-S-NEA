using UnityEngine;

public class Weapon : MonoBehaviour
{
    public void Active()
    {
        gameObject.SetActive(true);
    }

    public void NotActive()
    {
        gameObject.SetActive(false);
    }
}
