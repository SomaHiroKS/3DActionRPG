using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
	public FixedJoystick joystick;

	public GameObject player;

	private Vector3 vec;

	float playerY;
	void Start()
	{
		playerY = player.transform.position.y;
	}

	void Update()
	{
		if (joystick.Horizontal != 0 || joystick.Vertical != 0)
		{
			player.transform.position += player.transform.forward / 30f;
			player.transform.position += new Vector3(joystick.Horizontal / 30f, 0f, joystick.Vertical / 30f);
		}
		//vec = new Vector3(joystick.Horizontal / 30f, 0f, joystick.Vertical / 30f); // joystickの方向ベクトル

		// var moveX = player.transform.forward * joystick.Horizontal;
		// var moveZ = player.transform.forward * joystick.Vertical;

		// player.transform.position = new Vector3(moveX, playerY, moveZ);

	// 	Vector3 pos = player.transform.position;

	// 	pos.x += joystick.Horizontal * speed;
	// 	pos.z += joystick.Vertical * speed;

	// 	Vector3 diff = player.transform.position - pos;

	// 	if (diff.magnitude > 0.01f)
	// 	{
	// 		player.transform.rotation = Quaternion.LookRotation(diff * -1);
	// 	}
	// 	player.transform.position = pos;


		// Vector3 joyStickVecor = new Vector3(joystick.Horizontal, 1f, joystick.Vertical);
		// player.transform.position += player.transform.forward * joyStickVecor;
		//player.transform.localPosition += new Vector3(player.transform.localPosition.x + joystick.Horizontal / 50f, player.transform.localPosition.y, player.transform.localPosition.z + joystick.Vertical / 50f);
	}
}
