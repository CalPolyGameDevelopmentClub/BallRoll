using UnityEngine;
using System.Collections;


//When an entity touches an object this script is attached to,
//destory the object. (Much like a pickup)
public class PickupScript : MonoBehaviour {

	//When a player touches this object...
	void OnTriggerEnter()
	{
		//Delete it from the game world.
		Destroy(gameObject);
	}
}