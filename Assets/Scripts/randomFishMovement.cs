using UnityEngine;
using System.Collections;

public class randomFishMovement : MonoBehaviour {

    Transform raft;
    NavMeshAgent nav;
    public int swimRadius;

    // Use this for initialization
    void Awake () {
        nav = GetComponent<NavMeshAgent>();
        raft = GameObject.FindGameObjectWithTag("Raft").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 randomDirection = Random.insideUnitSphere * swimRadius;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, swimRadius, 1);
        Vector3 finalPosition = hit.position;
        nav.SetDestination(finalPosition);

        if (Vector3.Distance(transform.position, raft.position) > 20)
        {
            Destroy(gameObject);
            spawnFish.numFish = spawnFish.numFish - 1;
        }
            	
	}
}
