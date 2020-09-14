using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButtonController_Menu : MonoBehaviour
{
	[SerializeField]
	public GameObject popUpWindow;

	[SerializeField]
	public GameObject MenuWindow;


	public void onPressMapButton()
	{
		MenuWindow.SetActive(false);
		popUpWindow.SetActive(true);
	}
}
