using UnityEngine;
using System.Collections;

public class floatBob : MonoBehaviour {

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
        tempPos.y = tempValy + amplitude * Mathf.Sin(speed * Time.time);
        tempPos.x = tempValx + amplitude * (float)0.35 * Mathf.Sin(speed * Time.time);
        tempPos.z = tempValz + amplitude * Mathf.Sin((float)0.25 * speed * Time.time);
        transform.position = tempPos;
        tempRot.y = tempValRY + 150* amplitude * Mathf.Sin(speed * (float) 0.75 * Time.time);
        tempRot.z = tempValRZ + 150* amplitude * Mathf.Sin(speed * (float) 0.5 * Time.time);
        tempRot.x = tempValRX + 150* amplitude * Mathf.Sin(speed * (float) 0.2 * Time.time);
        transform.localEulerAngles = tempRot;
    }
}
