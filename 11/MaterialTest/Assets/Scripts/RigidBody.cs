using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour {
    private Rigidbody m_RigidBody;
    private Transform m_Transform;
	// Use this for initialization
	void Start () {
        m_RigidBody = gameObject.GetComponent<Rigidbody>();
        m_Transform = gameObject.GetComponent<Transform>();
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            m_RigidBody.MovePosition(m_Transform.position + Vector3.forward*0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_RigidBody.MovePosition(m_Transform.position + Vector3.back*0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_RigidBody.MovePosition(m_Transform.position + Vector3.left*0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_RigidBody.MovePosition(m_Transform.position + Vector3.right*0.1f);
        }
       
       
	}
}
