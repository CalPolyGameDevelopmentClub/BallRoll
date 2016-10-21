using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {
	//the speed that the player moves at
	public float Speed;
	//A gameObject that holds a position for the player to respawn at.
	public GameObject respawnPoint;
	void Start () {
		
	}
	
	void Update () {
		//Retrieve the input along the horizontal axis. (a,d or left and right on a joystick)
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//Retrieve the input along the vertical axis (w,s or up and down on a joystick);
        float moveVertical = Input.GetAxis ("Vertical");
        //Because the camera is tilted at a 45 degree angle, 'up' is up and to the left in world space.
        Vector3 upDir = new Vector3(1,0,1);
        //Because the camera is tilted at a 45 degree angle, 'down' is down and to the left in world space.
        
        Vector3 leftDir = new Vector3(1,0,-1);
        //Create the final movement vector by adding the horizontal and vertical contributions.
        Vector3 movement = (upDir * moveVertical + leftDir * moveHorizontal) * Speed;
        //Add a force to move the player.
		GetComponent<Rigidbody>().AddForce(movement);
		//If the player has fallen off the map, reset their position.
		checkIfShouldRespawn();
	}

	/**
	 * Reset the player's position after they fall off the map.
	 */
	void checkIfShouldRespawn()
	{
		//If the player is below a threshhold
		if(transform.position.y < -5)
		{
			//Set the player's position to the respawn point's position
			transform.position = respawnPoint.transform.position;
			//Stop the player's velocity (No movement)
			GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			//Stop the player's angular velocity (No rotating);
			GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);

		}
	}
	
}