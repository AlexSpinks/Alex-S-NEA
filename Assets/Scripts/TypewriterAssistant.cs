using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypewriterAssistant : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TypeWriter.add("Welcome to the tutorial");
        TypeWriter.add("Today we will learn how to play the game");
        TypeWriter.add("Press the W,A,S,D keys in order to move Up,Down,Left,Right respectively");

        TypeWriter.Activate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
