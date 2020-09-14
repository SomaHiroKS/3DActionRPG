using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpCloseButtonController : MonoBehaviour
{
	[SerializeField]
	public GameObject PopUpWindow;

	public void onPressCloseButton()
	{
		PopUpWindow.SetActive(!PopUpWindow.activeInHierarchy);
	}
}
