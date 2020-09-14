public class Define
{
	/// <summary>
	/// PlayerPrefsに登録しているキーの一覧
	/// </summary>
	/// <param name="USER_NAME"> ユーザー名 </param>
	/// <param name="CUSTOM_ID_SAVE_KEY"> サーバーに登録しているユーザーID</param>
	/// /// <param name="ENEMY_TYPE">仮でおいている敵情報</param>
	/// /// <param name="SELECT_STAGE_FLAG"> SelectStageを経由するかどうかのフラグ</param>
	public static readonly string USER_NAME = "userName";
	public static readonly string CUSTOM_ID_SAVE_KEY = "PLAYER_CUSTOM_ID_KEY";

	public static string ENEMY_TYPE = "ENEMY_TYPE";
	public static string SELECT_STAGE_FLAG = "SELECT_STAGE_FLAG";

	/// <summary>
	/// PlayFabにランキング要求するときのランキング名一覧
	/// </summary>
	/// <param name="SCORE_RANKING_NAME"> スコアのランキング </param>
	public static readonly string SCORE_RANKING_NAME = "ScoreRanking";
	public static readonly string STAGE_RANKING_NAME = "StageRanking";

	/// <summary>
	/// ステージデータのパス一覧
	/// </summary>
	/// <param name="STAGE_1_PATH"> Stage1のデータの場所 </param>
	public static readonly string STAGE_1_PATH = "/StageData/Stage1.csv";

	/// <summary>
	/// ステージ情報ID一覧
	/// </summary>
	public const int WALL_ID = 0;
	public const int NONE_ID = 1;
	public const int PLAYER_START_POS_ID = 2;

	/// <summary>
	/// ユーザーIDを作成するための文字列
	/// </summary>
	public static readonly string ID_STRING = "0123456789abcdefghijklmnopqrstuvwxyz";
}