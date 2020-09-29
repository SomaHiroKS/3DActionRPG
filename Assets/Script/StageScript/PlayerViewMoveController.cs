using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewMoveController : MonoBehaviour
{
	float wantRotation;
	public float turnTime = 1.0f;

	void Start()
	{
		wantRotation = transform.rotation.eulerAngles.y;
	}

	public void onPressLeftViewButton()
	{
		wantRotation -= 90f;
	}

	public void onPressRightViewButton()
	{
		wantRotation += 90f;
	}

	void Update()
	{
		Quaternion want = Quaternion.AngleAxis(wantRotation, new Vector3(0, 1, 0));
		transform.rotation = Quaternion.Lerp(transform.rotation, want, Time.deltaTime / turnTime);
	}
}
