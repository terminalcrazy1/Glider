using UnityEngine;

public class cameraRotation : MonoBehaviour
{
	/* FOV_x is a dummy variable. Eventually it will call the FOV class of
	 * Camera, to get a player set FOV value defined within a special
	 * settings/ui scene
	 */
	float FOV_x = 120;
	float rotateAngleModifier = 2.57f;
	int rotSpeedModifier_x = 8000;
	int rotSpeedModifier_y = 1000;
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
		// Variables
		float screenCenter_x = Screen.width/2;
		float screenCenter_y = Screen.height/2;

		float mousePosition_x = Input.mousePosition.x;
		float mousePosition_y = Input.mousePosition.y;
		if (mousePosition_y <= 100) {
			mousePosition_y = 0;
		}
		float rotateX = ((screenCenter_x - mousePosition_x)/pixelsPerDegree_x)/rotSpeedModifier_x;
		float rotateY = ((screenCenter_y - mousePosition_y)/pixelsPerDegree_y)/rotSpeedModifier_y;

		float oldCameraRotation_x = Camera.transform.rotation.y;
		float newCameraRotation_x = oldCameraRotation_x + rotateX;
		float oldCameraRotation_y = Camera.transform.rotation.z;
		float newCameraRotation_y = oldCameraRotation_y + rotateY;

		float rotateCameraAbsolute_z = (rotateX/rotateAngleModifier)*(rotSpeedModifier_x/100);
		rotateCameraAbsolute_x = rotateCameraAbsolute_x + newCameraRotation_x * -1;
		rotateCameraAbsolute_y = rotateCameraAbsolute_y + newCameraRotation_y;

		if (rotateCameraAbsolute_y <= -35) {
			rotateCameraAbsolute_y = -35;
			// Commented out because lift is not yet an existing parameter
			// currentLift = 0
		} else if (rotateCameraAbsolute_y >= 90) {
			rotateCameraAbsolute_y = 90;
			// Commented out for same reason as above
			// currentLift = 0
		}
		// Functionality
		Camera.transform.rotation =  Quaternion.Euler(rotateCameraAbsolute_y, rotateCameraAbsolute_x, rotateCameraAbsolute_z);
    }
}
