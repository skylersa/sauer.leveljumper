using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	public Transform player;

	void Update ()
	{
		transform.position = new Vector3 (player.position.x, player.position.y, transform.position.z);
		transform.rotation = Quaternion.FromToRotation ((Vector2)Input.acceleration, Vector3.down);
	}
}
