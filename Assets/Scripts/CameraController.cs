using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    // A reference to the player, set via inspector
    public GameObject player;
    //An offset from the camera to the player. Locks the camera 'behind' the player during runtime.
    private Vector3 offset;

    void Start ()
    {
        //When the game starts, determine the distance and direction
        //From the camera to the player
        offset = transform.position - player.transform.position;
    }
    
    void LateUpdate ()
    {
        //During gameplay, set the position of the camera to the player's position 
        //plus the initial offset
        transform.position = player.transform.position + offset;
    }
}