using UnityEngine;
using System.Collections;

public class posText : MonoBehaviour {

    public Camera cameraRig;
    private Vector3 rot;
    private Vector3 scale;
    private const float scaling = (float)0.007194;
    // Use this for initialization
    void Start () {
        gameObject.transform.position = new Vector3((float)-0.07, (float)-0.23, (float)0.78);
        rot.x = (float)7.5;
        rot.y = (float)-9.96;
        rot.z = (float)2.55;
        scale.x = scaling;
        scale.y = scaling;
        scale.z = scaling;
        gameObject.transform.localEulerAngles = rot;
        gameObject.transform.localScale = scale;
        gameObject.transform.SetParent(cameraRig.transform);
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
