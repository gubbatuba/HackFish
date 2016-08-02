using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupParent : MonoBehaviour {


    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    
	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);

        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Holding 'touch' on trigger");
        }

        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Activated 'touchdown' on trigger");
        }

        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Activated 'touchup' on trigger");
        }

        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Holding 'press' on trigger");
        }

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Activated 'pressdown' on trigger");
        }

        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Activated 'pressup' on trigger");
        }
    }

    void OnTriggerStay (Collider col)
    {
        Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay");
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have collided with " + col.name + " while holding down Touch");
            col.attachedRigidbody.isKinematic = true;
            col.gameObject.transform.SetParent(gameObject.transform);
        }
    }
}
