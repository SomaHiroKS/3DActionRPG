using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PlayFab;
using PlayFab.ClientModels;
public class CreateAccountController : MonoBehaviour
{
	public InputField nameField;

	public Text errorText;
	private bool isCreateAccount;
	private string customId;

	private string playerName = "名無し";

	void Start()
	{
		errorText.text = "";
	}

	/// <summary>
	/// アカウント作成OKボタンのみ別仕様
	/// </summary>
	public void onPressOkButton()
	{
		/// account作成処理
		if (nameField.text != "" && nameField.text != null)
		{
			playerName = nameField.text;
		}
		login();
	}

	/// <summary>
	/// ログイン処理
	/// </summary>
	private void login()
	{
		customId = createCustomId();
		var request = new LoginWithCustomIDRequest
		{
			CustomId = customId,
			CreateAccount = true,
		};
		PlayFabClientAPI.LoginWithCustomID(request, Success, Error);
	}

	private string createCustomId()
	{
		int idLength = 32;
		StringBuilder stringBuffer = new StringBuilder(idLength);
		var random = new System.Random();

		for (int i = 0; i < idLength; i++)
		{
			stringBuffer.Append(Define.ID_STRING[random.Next(Define.ID_STRING.Length)]);
		}

		return stringBuffer.ToString();
	}

	private void Success(LoginResult result)
	{
		/// 同一IDを持っていた場合は再度アカウント作成
		if (!result.NewlyCreated)
		{
			login();
			return;
		}
		else
		{
			saveCustomId();
			setUserName();
		}
	}

	private void saveCustomId()
	{
		PlayerPrefs.SetString(Define.CUSTOM_ID_SAVE_KEY, customId);
	}

	private void setUserName()
	{
		PlayerPrefs.SetString(Define.USER_NAME, playerName);
		SceneManager.LoadScene("SelectStage"); // 仮
	}

	private void Error(PlayFabError error)
	{
		errorText.text = $"ERROR!\n{error.GenerateErrorReport()}";
	}
}
