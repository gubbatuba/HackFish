using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupParent : MonoBehaviour {

    public Rigidbody rigidBodyAttachPoint;
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    FixedJoint fixedJoint;
    public Transform spear;

	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);

        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Resetting object");
            spear.transform.position = device.transform.pos;
            spear.GetComponent<Rigidbody>().velocity = Vector3.zero;
            spear.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

    }

    void OnTriggerStay (Collider col)
    {
        Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay");
        if (fixedJoint == null && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            fixedJoint = col.gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = rigidBodyAttachPoint;
            
        }
        else if (fixedJoint != null && device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            GameObject go = fixedJoint.gameObject;
            Rigidbody rigidBody = go.GetComponent<Rigidbody>();
            Destroy(fixedJoint);
            fixedJoint = null;
            tossObject(rigidBody);
        }
    }

    void tossObject(Rigidbody rigidBody)
    {
        Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
        if (origin!=null)
        {
            rigidBody.velocity = origin.TransformVector(device.angularVelocity);
            rigidBody.angularVelocity = origin.TransformVector(device.angularVelocity);
        }
        else
        {
            rigidBody.velocity = device.velocity;
            rigidBody.angularVelocity = device.angularVelocity;
        }
    }
}
