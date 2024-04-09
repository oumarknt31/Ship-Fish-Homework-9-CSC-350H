using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private FishCollector fishInScene;
    private GameObject target;
    private Vector3 direction;
    private Rigidbody2D rb;
    static private int totalPoints=0;

    void Start()
    {
        fishInScene = Camera.main.GetComponent<FishCollector>();
        rb = GetComponent<Rigidbody2D>();
    }

    IEnumerator OnMouseDown()
    {
        while (fishInScene.FishList.Count != 0)
        {
            findNearestFish();

            // Wait until boat stops
            yield return new WaitUntil(() => rb.velocity.magnitude < 0.1f);
            Debug.Log("YOUR SCORE IS || " + totalPoints + " ||");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == target)
        {
            //Destroy(target);
            Fish curfish = target.GetComponent<Fish>();
            curfish.DestroyFish();
            fishInScene.FishList.Remove(target);
            totalPoints += curfish.PointValue;
            rb.velocity = Vector2.zero;
            //Debug.Log("YOUR SCORE IS || " + totalPoints + " ||");
        }
    }

    void findNearestFish()
    {

        // Start with the first element in fishList
        target = fishInScene.FishList[0];
        // Start with the distance of the first fish
        float nearestDistance = Vector3.Distance(transform.position, target.transform.position);

        foreach (GameObject fish in fishInScene.FishList)
        {
            // Store the comparing distance of the other fish
            float comparingDistance = Vector3.Distance(transform.position, fish.transform.position);
            // Compare distances
            if (comparingDistance < nearestDistance)
            {
                // Set the nearestDistance
                nearestDistance = comparingDistance;
                // Set new target
                target = fish;
            }
        }

        // Get direction
        direction = (target.transform.position - transform.position).normalized;
        // Blast off
        rb.AddForce(direction * 5f, ForceMode2D.Impulse);

    }
}
