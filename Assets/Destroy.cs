using UnityEngine;

public class Destroy : StateMachineBehaviour
{
    // Destroys the game object when this animation state is entered (e.g., at the end of a death animation).
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Destroy(animator.gameObject);
    }
}
