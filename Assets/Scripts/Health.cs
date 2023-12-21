using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    GameObject HP3;
    GameObject HP2;
    GameObject HP1;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 2)
        {
            
        }
    }
   public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //death anim
            //game over
        }
    }
    public void Heal(int amount)
    {
        if (currentHealth != 3)
        {
            currentHealth+=amount;
        }
    }
}
