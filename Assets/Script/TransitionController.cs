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
		if (PlayerPrefs.HasKey(Define.USER_NAME))
		{
			SceneManager.LoadScene("SelectStage");
			//ユーザーネームの確認
			//Debug.Log(PlayerPrefs.GetString(Define.USER_NAME, "0"));
		}
        else
        {
			SceneManager.LoadScene("InputName");
			//ユーザーネームの確認
			//Debug.Log(PlayerPrefs.GetString(Define.USER_NAME, "0"));
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
	}
}
