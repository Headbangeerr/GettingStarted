using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {

    private Transform m_Transform;
	// Use this for initialization
    //该方法只在游戏开始时执行一次，因此用于初始化
	void Start () {
        m_Transform=gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
            m_Transform.Translate(Vector3.forward * 0.1f, Space.Self);//该方法需要两个参数，Vector3是一个结构体
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Transform.Translate(Vector3.back * 0.1f, Space.Self);//该方法需要两个参数，Vector3是一个结构体
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Transform.Translate(Vector3.left * 0.1f, Space.Self);//该方法需要两个参数，Vector3是一个结构体
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_Transform.Translate(Vector3.right * 0.1f, Space.Self);//该方法需要两个参数，Vector3是一个结构体
        }

	}
}
