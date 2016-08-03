using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class stabFish: MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpearHead"))
        {
            spawnFish.numFish = spawnFish.numFish - 1;
            Debug.Log("Fish count = " + spawnFish.numFish);
            spawnFish.score += 1;
            Destroy(gameObject);
        }
    }
}
