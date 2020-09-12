using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 画面遷移系の処理をすべてここに書く
/// 空のGameObject「Transition」を作成しこのクラスをアタッチ
/// ボタンにこのTransitionオブジェクトを設定して該当関数をセットさせる
/// </summary>
public class TransitionController : MonoBehaviour
{
	AutoLoadScene autoLoad;

	//BackTo～
	public void onPressBackToStart()
	{
		SceneManager.LoadScene("Start");
	}

	//Goto～

	public void onPressGoToRanking()
	{
		SceneManager.LoadScene("Ranking");
	}

	public void onPressGoToStageSelectOrInputName()
	{
		autoLoad = gameObject.GetComponent<AutoLoadScene>();
		if (PlayerPrefs.HasKey(Define.USER_NAME))
		{
			if(PlayerPrefs.HasKey(Define.SELECT_STAGE_FLAG))
            {
				autoLoad.BattleOrStageLoad();
            }
            else
            {
				SceneManager.LoadScene("SelectStage");
            }
		}
        else
        {
			SceneManager.LoadScene("InputName");
		}
	}

	public void onPressGoToShop()
	{
		SceneManager.LoadScene("Shop");
	}

	public void onPressGoToSettings()
	{
		SceneManager.LoadScene("Settings");
	}

	public void onPressGoToStage()
	{
		SceneManager.LoadScene("Stage");
		PlayerPrefs.SetString(Define.SELECT_STAGE_FLAG,"Stage");
	}
}
