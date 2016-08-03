using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class stabFish: MonoBehaviour {


    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("SpearHead"))
        {
            spawnFish.numFish = spawnFish.numFish - 1;
            Debug.Log("Fish count = " + spawnFish.numFish);
            spawnFish.score += 1;
            gameObject.transform.SetParent(col.gameObject.transform);
            anim.SetTrigger("FishDead");
            Destroy(gameObject, 4.5f);
        }
    }
}
