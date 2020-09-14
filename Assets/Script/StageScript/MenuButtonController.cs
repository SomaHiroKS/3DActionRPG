using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
	public GameObject menuWindow;

	/// <summary>
	/// メニューボタンを押すとメニューウィンドウを表示させる
	/// </summary>
	public void onPressMenuButton()
	{
		menuWindow.SetActive(!menuWindow.activeInHierarchy);
	}
}
