using UnityEngine;

public class followCamera : MonoBehaviour
{
	public GameObject Plane;
	public GameObject Camera;
	public Vector3 Origin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Origin = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		Vector3 CameraNewPosition = Plane.transform.position;
		Camera.transform.position = CameraNewPosition;
    }
}
