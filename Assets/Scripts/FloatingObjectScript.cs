using UnityEngine;
using System.Collections;


//Creates a slowly rotating object
public class FloatingObjectScript : MonoBehaviour {

	//Not used in this script.
	void Start(){

	}
	void Update () {
		//Make the object spin slightly as time goes by.
		transform.Rotate(new Vector3(1f,1.5f,0));

	}

}

