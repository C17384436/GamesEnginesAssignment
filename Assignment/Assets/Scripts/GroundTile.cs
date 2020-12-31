using UnityEngine;


public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnCoins();
    }

    //Calling the SpawnTile function from our GroundSpawner script and destroying the existing planes 2 seconds later
    void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject coinPrefab;

    //Function which spawns coins on the generated plain
    void SpawnCoins()
    {
        //Variable to choose the amount of coins to be repeatedly spawned
        int coinsToSpawn = 1;
        //For statement which spawns the coins on a random point
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    // Function to find a random point to spawn the coins any time it's called
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        //Setting the min and max ranges for the coins to be spawned
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        //Setting the height at which the coins should be spawned
        point.y = 25;

        //returning the value of point
        return point;
    }
}
