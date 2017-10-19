using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
    private Door m_Door;
	// Use this for initialization
	void Start () {
        m_Door= GameObject.Find("DoorParent").GetComponent<Door>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider coll) 
    {
        if (coll.gameObject.name == "Student") 
        {
            m_Door.OpenDoor();
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "Student") 
        {
            m_Door.CloseDoor();
        }
    }
}
