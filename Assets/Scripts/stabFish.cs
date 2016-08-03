using UnityEngine;
using System.Collections;

public class stabFish: MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("spearhead hit fish");
        if (other.gameObject.CompareTag("Fish"))
        {
            Destroy(other);
            spawnFish.numFish = spawnFish.numFish - 1;
        }
    }
}
