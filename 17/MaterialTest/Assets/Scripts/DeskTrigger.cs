using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour {

    private GameObject[] m_Desk;
	// Use this for initialization
	void Start () {
        m_Desk=GameObject.FindGameObjectsWithTag("Desks");
	}
	
	// Update is called once per frame
	void Update () {
        /*
		if(Input.GetKeyDown(KeyCode.Z)){
            //up.
            DeskUp();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            //down.
        }
         */
	}
    void DeskUp() { 
         foreach(GameObject temp in m_Desk){
             temp.GetComponent<Transform>().Translate(Vector3.up * 2, Space.Self);
        }
    }
    void DeskDown() {
        foreach (GameObject temp in m_Desk)
        {
            temp.GetComponent<Transform>().Translate(Vector3.up * -2, Space.Self);
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Student")
        {
            DeskUp();
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "Student")
        {
            DeskDown();
        }
    }
}
