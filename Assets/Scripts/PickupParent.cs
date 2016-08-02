using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupParent : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public Transform weapon;

	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);

        if (weapon != null && device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Resetting object");
            weapon.transform.position = new Vector3((float)-0.4, (float)2.97, 0);
            weapon.GetComponent<Rigidbody>().velocity = Vector3.zero;
            weapon.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

    }

    void OnTriggerStay (Collider col)
    {
        
        Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay");
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && !col.isTrigger)
        {
            Debug.Log("You have collided with " + col.name + " while holding down Touch");
            col.attachedRigidbody.isKinematic = true;
            col.gameObject.transform.SetParent(gameObject.transform);
            weapon = col.attachedRigidbody.transform;
        }
        else if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        { 
            col.gameObject.transform.SetParent(null);
            col.attachedRigidbody.isKinematic = false;
            tossObject(col.attachedRigidbody);
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
