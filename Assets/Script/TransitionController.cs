using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 画面遷移系の処理をすべてここに書く
/// 空のGameObject「Transition」を作成しこのクラスをアタッチ
/// ボタンにこのTransitionオブジェクトを設定して該当関数をセットさせる
/// </summary>
public class TransitionController : MonoBehaviour
{
	public void onPressBackToStart()
	{
		SceneManager.LoadScene("Start");
	}
}
