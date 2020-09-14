using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoadScene : MonoBehaviour
{
	public void BattleOrStageLoad()
	{
		if (PlayerPrefs.HasKey(Define.ENEMY_TYPE))
		{
			SceneManager.LoadScene("Battle");
		}
		else
		{
			SceneManager.LoadScene("Stage");
		}
	}
}
