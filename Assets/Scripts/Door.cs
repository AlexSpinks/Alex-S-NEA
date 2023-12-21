using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    Animator am;
    bool touch = false;
    public SpriteRenderer srr;
    public Sprite open;
    public Sprite Closed;
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        srr = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touch = true;
           
        }
        else
        {
            touch = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (touch == true)
        {

           
            am.SetBool ("open" , true);

        }
        if (touch==true&&Input.GetKeyDown("f"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
