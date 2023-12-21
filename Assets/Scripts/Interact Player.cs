using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractPlayer : MonoBehaviour
{
    Animator am;
    bool collect = false;
    public AudioSource pickup;
    public GameObject coin;
    public SpriteRenderer sr;
    private Score Score;


    // Start is called before the first frame update
    void Start()
    {
        pickup = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            

            collect = true;
            
        }
        else
        {
            collect = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (collect == true)
        {
            var scorecomponent = GetComponent<Score>();
            if (scorecomponent != null)
            {
                scorecomponent.ScoreUP(1);
            }
            StartCoroutine(ChangeSprite());
           
            collect = false;

        }
    }

    private IEnumerator ChangeSprite()
    {

        pickup.Play();
        sr.enabled = false;
        yield return new WaitForSeconds(2f);
        Destroy(coin);
        
    }   
}
