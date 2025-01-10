using UnityEngine;

public class rotation : MonoBehaviour
{
	public float FOV_x = 120;
	float FOV_y;
	float pixelsPerDegree_x;
	float pixelsPerDegree_y;

	void Start()
	{
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
		float rotateX = (screenCenter_x - mousePosition_x)/pixelsPerDegree_x;
		float rotateY = (screenCenter_y - mousePosition_y)/pixelsPerDegree_y;
    }
}
