using UnityEngine;
using System.Collections;

public class sharkMove : MonoBehaviour {

    /* the object to orbit */
    public Transform target;

    /* speed of orbit (in degrees/second) */
    public float speed;

    void FixedUpdate()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}
