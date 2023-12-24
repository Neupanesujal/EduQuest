using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component

    void Start()
    {
        // Play the animation when the game starts
        animator.Play("YourAnimationName"); // Replace "YourAnimationName" with the actual animation state name
    }
}