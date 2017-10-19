using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {//该方法只会在开始时自动调用一次
        Debug.Log("STRAT");
	}
	
	// Update is called once per frame
	void Update () {//该方法一帧调用一次，相当于一秒钟调用60次左右
        Debug.Log("Update");
	}
}
