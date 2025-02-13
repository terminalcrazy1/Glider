using UnityEngine;

public class cameraMovement : MonoBehaviour
{
	GameObject Camera;
	// Dummy variable. Will be dependent on various factors once they are set
	float MoveSpeed = 5;

    void Start()
    {
        Camera = GameObject.Find("Main Camera");
    }

    void FixedUpdate()
    {

    }
}
