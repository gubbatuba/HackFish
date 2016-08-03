using UnityEngine;
using System.Collections;

public class floatRaft : MonoBehaviour {

    public float amplitude;          //Set in Inspector 
    public float speed;                  //Set in Inspector 
    private float tempValy;
    private float tempValx;
    private float tempValz;
    private Vector3 tempPos;
    private Vector3 tempRot;
    private float tempValRY;
    private float tempValRX;
    private float tempValRZ;

    void Start()
    {
        tempValy = transform.position.y;
        tempValx = transform.position.x;
        tempValz = transform.position.z;
        tempValRX = transform.rotation.x;
        tempValRY = transform.rotation.y;
        tempValRZ = transform.rotation.z;
    }

    void Update()
    {
        tempPos.y = tempValy + amplitude * (float)0.5 * Mathf.Sin(speed * Time.time);
        tempPos.x = tempValx + amplitude * (float) 0.5 * Mathf.Sin(speed * Time.time);
        tempPos.z = tempValz + amplitude * (float)0.25 * Mathf.Sin(speed * Time.time);
        transform.position = tempPos;
        tempRot.y = tempValRY + amplitude * Mathf.Sin(speed * (float) 0.75 * Time.time);
        tempRot.z = tempValRZ + (float)0.01 * amplitude * Mathf.Sin(speed * (float) 0.5 * Time.time);
        tempRot.x = tempValRX + (float)0.01 * amplitude * Mathf.Sin(speed * (float) 0.2 * Time.time);
        transform.localEulerAngles = tempRot;
    }
}
