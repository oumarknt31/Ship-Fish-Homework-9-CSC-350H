using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularFish : Fish
{
    public override int PointValue { get { return 1; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void DestroyFish()
    {
        Destroy(gameObject);
    }
}