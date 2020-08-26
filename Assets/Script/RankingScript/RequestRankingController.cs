using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class RequestRankingController : MonoBehaviour
{
	public Text showRankingText;
	void Start()
	{
		showRankingText.text = "";
		/// 最初はスコアランキングをデフォルト表示
		getScoreRanking();
	}

	/// <summary>
	/// Scoreのランキングを読み込むための関数
	/// </summary>

	public void getScoreRanking()
	{
		var request = new GetLeaderboardRequest
		{
			StatisticName = Define.SCORE_RANKING_NAME,
			StartPosition = 0, // 何位以降のランキングを取得するか指定
			MaxResultsCount = 5, // 最大件数
		};
		PlayFabClientAPI.GetLeaderboard(request, showScoreRanking, OnScoreRankingError);
	}

	private void showScoreRanking(GetLeaderboardResult result)
	{
		showRankingText.text = "";
		showRankingText.text += "ScoreRanking\n";
		foreach (var data in result.Leaderboard)
		{
			showRankingText.text += $"{data.Position + 1}位: {data.DisplayName} - {data.StatValue}\n";
		}
	}

	private void OnScoreRankingError(PlayFabError error)
	{
		showRankingText.text += $"ERROR!\n{error}";
	}

	/// <summary>
	/// Stage進行度ランキングを取得するための関数
	/// </summary>
	public void getStageRanking()
	{
		var request = new GetLeaderboardRequest
		{
			StatisticName = Define.STAGE_RANKING_NAME,
			StartPosition = 0,
			MaxResultsCount = 5,
		};
		PlayFabClientAPI.GetLeaderboard(request, showStageRanking, OnStageRankingError);
	}

	private void showStageRanking(GetLeaderboardResult result)
	{
		showRankingText.text = "";
		showRankingText.text += "StageRanking\n";
		foreach (var data in result.Leaderboard)
		{
			showRankingText.text += $"{data.Position + 1}位: {data.DisplayName} - {data.StatValue}\n";
		}
	}

	private void OnStageRankingError(PlayFabError error)
	{
		showRankingText.text += $"ERROR!\n{error}";
	}
}
