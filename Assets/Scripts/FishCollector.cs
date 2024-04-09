using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishCollector : MonoBehaviour
{
    //[serelaziedFiald] List<GameObject> fishList = new List<GameObject>();
    [SerializeReference] GameObject explodingFishPrefab;
    [SerializeReference] GameObject BurningFishPrefab;

    [SerializeReference] GameObject regularFishPrefab;
    List<GameObject> fishList = new List<GameObject>();

    public List<GameObject> FishList
    {
        get { return fishList; }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {

            spawnFish();

        }
    }

    void spawnFish()
    {
        int randomFish = Random.Range(0, 3);


        //Instantiate (fish, )
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Instantiate<GameObject>(fish);
        /*GameObject fish = Instantiate<GameObject>(BurningFishPrefab);
        fish.transform.position = worldPosition;
        Debug.Log("burning fish created");

        fishList.Add(fish);*/

        if (randomFish == 0)
        {


            GameObject fish = Instantiate<GameObject>(explodingFishPrefab);
            fish.transform.position = worldPosition;
            Debug.Log("Exploding fish created");

            fishList.Add(fish);
        }

        else if (randomFish == 1)
        {


            GameObject fish = Instantiate<GameObject>(BurningFishPrefab);
            fish.transform.position = worldPosition;
            Debug.Log("burning fish created");

            fishList.Add(fish);
        }

        else if (randomFish == 2)
        {


            GameObject fish = Instantiate<GameObject>(regularFishPrefab);
            fish.transform.position = worldPosition;
            Debug.Log("regular fish created");

            fishList.Add(fish);
        }
    }

}