using UnityEngine;
using System.Collections;

public class spawnFish : MonoBehaviour {

    public GameObject fish;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public float maxFish = 20f;

    private int numFish;

	// Use this for initialization
	void Start ()
    {
        numFish = 0;
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}

    void Spawn()
    {
        if (numFish <= maxFish)
        {
            numFish = numFish + 1;
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(fish, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}
