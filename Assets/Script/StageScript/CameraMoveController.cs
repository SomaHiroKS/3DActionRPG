using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
	[SerializeField]
	public GameObject player;

	void Update()
	{
		transform.forward = player.transform.forward;
	}
}
