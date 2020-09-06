using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickTest : MonoBehaviour
{
	public FixedJoystick joystick;

	public GameObject player;

	void Start()
	{
		player.transform.position = new Vector3(0, 0, 0);
	}
	void Update()
	{
		player.transform.position = new Vector3(player.transform.position.x + joystick.Horizontal, player.transform.position.y, player.transform.position.z + joystick.Vertical);
	}
}
