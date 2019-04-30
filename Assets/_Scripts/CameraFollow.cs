using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	//public Transform target;
	//private Transform positioner;

	//private float startHeight;
	//private float sumHeight;

	//void Awake()
	//{
	//	positioner = transform;
	//}

	//void Start()
	//{
	//	startHeight = positioner.position.y;
	//	sumHeight = startHeight - target.position.y;
	//}

	//void Update()
	//{
	//	positioner.position = new Vector3(target.position.x, target.position.y + sumHeight, target.position.z);
	//	//transform.LookAt(target);
	//	transform.eulerAngles = new Vector3(0, 0, 0);
	//}

	//public Transform thePlayer;
	//public float kulaX;
	//public float kulaY;
	//public float kulaZ;

	//private void Update()
	//{
	//	kulaX = thePlayer.transform.eulerAngles.x;
	//	kulaY = thePlayer.transform.eulerAngles.y;
	//	kulaZ = thePlayer.transform.eulerAngles.z;

	//	transform.eulerAngles = new Vector3(kulaX - kulaX, kulaY, kulaZ - kulaZ);
	//	transform.LookAt(thePlayer);
	//}

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	private void FixedUpdate()
	{
		Vector3 wantedPosition = target.position + offset;
		Vector3 smoothPosition = Vector3.Lerp(transform.position, wantedPosition, smoothSpeed);
		transform.position = smoothPosition;
		transform.LookAt(target);
	}

}
