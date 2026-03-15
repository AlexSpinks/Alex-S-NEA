using UnityEngine;

public class TypewriterAssistant : MonoBehaviour
{
    private void Start()
    {
        TypeWriter.Add("Welcome to the tutorial");
        TypeWriter.Add("Today we will learn how to play the game");
        TypeWriter.Add("Press the W,A,S,D keys in order to move Up,Down,Left,Right respectively");
        TypeWriter.Add("Press the spacebar key in order to attack");
        TypeWriter.Add("Running into health potions will heal you by 1 health point");
        TypeWriter.Add("Running into gold coins will increase your score");

        TypeWriter.Activate();
    }
}
