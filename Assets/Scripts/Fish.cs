using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    // Property to set the point value of each fish
    public abstract int PointValue { get; }

    // Abstract method to destroy the fish
    public abstract void DestroyFish();
}
