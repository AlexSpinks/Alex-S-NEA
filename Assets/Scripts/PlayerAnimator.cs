using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;
    public Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x !=0 || pm.moveDir.y != 0)
        {
            am.SetBool("Move", true);
            SpriteDirectionChecker();

        }
        else
        {
            am.SetBool("Move", false);

        }
        if (playerHealth.currentHealth<=0 )
        {
            am.SetBool("Dead", true);
            SpriteDirectionChecker();
        }
        else
        {
            am.SetBool("Dead", false);
            

        }
        if (Input.GetKeyDown("space"))
        {
            am.SetBool("Attack",true);
        }
        else
        {
            am.SetBool("Attack", false);
        }
    }
    void SpriteDirectionChecker()
    {
        if (pm.lastHorizontalVector < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
