using UnityEngine;
using System.Collections;

public class spawnFish : MonoBehaviour {

    public GameObject fish;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public int maxFish = 10;
    public int minimumSize = 1;
    public int maximumSize = 50;
    public float normalSpeed = 50f;

    public static int numFish;

	// Use this for initialization
	void Start ()
    {
        numFish = 0;
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}

    void Spawn()
    {
        if (numFish < maxFish)
        {
            numFish = numFish + 1;
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            float newFishSize = Random.Range(minimumSize, maximumSize);
            int newFishSpeed;
            NavMeshAgent speedAgent;
            GameObject fishInstance;
            fishInstance = Instantiate(fish, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
            fishInstance.transform.localScale = new Vector3(newFishSize, newFishSize, newFishSize);
            speedAgent = fishInstance.GetComponent<NavMeshAgent>();
            speedAgent.speed = normalSpeed / Mathf.Sqrt(newFishSize);
        }
    }

    void Caught(GameObject fish)
    {
        Destroy(fish);
        numFish = numFish - 1;
    }
}
