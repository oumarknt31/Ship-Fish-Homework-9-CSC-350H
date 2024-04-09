using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningFish : AnimatedFish
{
    public int BurningSeconds { get; set; }
    private Timer burnTimer;
    private Animator anim;
    [SerializeField] private GameObject burning;

    public override int PointValue { get { return 2; } }

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }
    //Explosion exp;

    public BurningFish(GameObject prefabAnimation, int pointValue)
    : base(prefabAnimation)
    {
        //BurningSeconds = burningSeconds;
        //burnTimer = gameObject.AddComponent<Timer>(); // Assuming Timer class is defined elsewhere
        //burnTimer.setTimer(3);
        //burnTimer.Run();
        //PointValue = pointValue;
    }


    public override void DestroyFish()
    {
        //Instantiate(burning, transform.position, Quaternion.identity);
        anim.enabled = true;
        Destroy(gameObject,2f);
        // Play the burning animation
        /*Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetBool("IsBurning", true); // Assuming "IsBurning" is a boolean parameter in the burning animation controller
        }

        // Delay destruction of the GameObject until the animation completes
        // Adjust the delay time based on the duration of your burning animation
        float animationDuration = 2.0f; // Example animation duration (adjust as needed)
        Destroy(gameObject, animationDuration);*/
    }
}