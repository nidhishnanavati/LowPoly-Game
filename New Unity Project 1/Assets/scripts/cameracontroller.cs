﻿using System.Collections;
using UnityEngine;

public class cameracontroller : MonoBehaviour {


	public GameObject player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
