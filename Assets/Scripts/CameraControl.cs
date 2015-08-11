using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	public Vector3 offset;
	public Transform cam;
	
	// Update is called once per frame
	void Update ()
	{
		cam.position = transform.position + offset;
		cam.LookAt(transform);
	}
}

