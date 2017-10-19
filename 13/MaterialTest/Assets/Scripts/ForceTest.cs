using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour {

    private Rigidbody m_Rigidbody;
	// Use this for initialization
	void Start () {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        m_Rigidbody.AddForce(Vector3.forward*50, ForceMode.Force);
	}
}
