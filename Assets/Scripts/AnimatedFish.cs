using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine;

public abstract class AnimatedFish : Fish
{
    // Property to hold the animation prefab of the fish
    public GameObject PrefabAnimation { get; set; }

    // Constructor to initialize the prefabAnimation
    public AnimatedFish(GameObject prefabAnimation)
    {
        PrefabAnimation = prefabAnimation;
    }
}


