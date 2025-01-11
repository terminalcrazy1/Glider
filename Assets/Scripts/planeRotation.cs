using UnityEngine;

public class planeRotation : MonoBehaviour
{
	float FOV_x = 120;
	int rotSpeedModifier = 1000;
	float rotateCameraAbsolute_x = 0;
	float rotateCameraAbsolute_y = 0;
	GameObject Camera;
	float FOV_y;
	float pixelsPerDegree_x;
	float pixelsPerDegree_y;

	void Start()
	{
		Camera = GameObject.Find("Main Camera");
		FOV_y = (FOV_x/16)*9;
		pixelsPerDegree_x = FOV_x/Screen.width;
		pixelsPerDegree_y = FOV_y/Screen.height;
	}

    void FixedUpdate()
    {
		float screenCenter_x = Screen.width/2;
		float screenCenter_y = Screen.height/2;
		float mousePosition_x = Input.mousePosition.x;
		float mousePosition_y = Input.mousePosition.y;
		float rotateX = ((screenCenter_x - mousePosition_x)/pixelsPerDegree_x)/rotSpeedModifier;
		float rotateY = ((screenCenter_y - mousePosition_y)/pixelsPerDegree_y)/rotSpeedModifier;
		float oldCameraRotation_x = Camera.transform.rotation.y;
		float newCameraRotation_x = oldCameraRotation_x + rotateX;
		float oldCameraRotation_y = Camera.transform.rotation.z;
		float newCameraRotation_y = oldCameraRotation_y + rotateY;
		float oldCameraRotation_z = Camera.transform.rotation.x;
		rotateCameraAbsolute_x = rotateCameraAbsolute_x + newCameraRotation_x;
		rotateCameraAbsolute_y = rotateCameraAbsolute_y + newCameraRotation_y;
		Camera.transform.rotation =  Quaternion.Euler(rotateCameraAbsolute_y, rotateCameraAbsolute_x, oldCameraRotation_z);
    }
}
