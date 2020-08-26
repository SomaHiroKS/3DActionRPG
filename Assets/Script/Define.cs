public class Define
{
	/// <summary>
	/// PlayerPrefsに登録しているキーの一覧
	/// </summary>
	/// <param name="USER_NAME"> ユーザー名 </param>
	/// <param name="CUSTOM_ID_SAVE_KEY"> サーバーに登録しているユーザーID</param>
	public static readonly string USER_NAME = "userName";
	public static readonly string CUSTOM_ID_SAVE_KEY = "PLAYER_CUSTOM_ID_KEY";

	/// <summary>
	/// PlayFabにランキング要求するときのランキング名一覧
	/// </summary>
	/// <param name="SCORE_RANKING_NAME"> スコアのランキング </param>
	public static readonly string SCORE_RANKING_NAME = "ScoreRanking";
	public static readonly string STAGE_RANKING_NAME = "StageRanking";


	/// <summary>
	/// ユーザーIDを作成するための文字列
	/// </summary>
	public static readonly string ID_STRING = "0123456789abcdefghijklmnopqrstuvwxyz";
}