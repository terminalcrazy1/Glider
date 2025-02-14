using UnityEngine;

public class followCamera : MonoBehaviour
{
	GameObject Plane;
	GameObject Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Plane = GameObject.Find("Bean Plane");
		Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		Vector3 CameraNewPosition = Plane.transform.position;
		Camera.transform.position = CameraNewPosition;
    }
}
