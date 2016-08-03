using UnityEngine;
using System.Collections;

public class fishMove: MonoBehaviour
{
    Transform bobble;
    NavMeshAgent nav;


    void Awake()
    {
        bobble = GameObject.FindGameObjectWithTag("Bobble").transform;
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        nav.SetDestination(new Vector3(bobble.position.x, bobble.position.y-(float)10, bobble.position.z));
    }
}
