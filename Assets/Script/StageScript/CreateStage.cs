﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class CreateStage : MonoBehaviour
{
	/// <summary>
	/// 壁オブジェクト
	/// </summary>
	[SerializeField]
	public GameObject wallObj;

	/// <summary>
	/// Stage情報を持つ二次元配列
	/// </summary>
	int[,] stageMapData;
	int stageHeight;
	int stageWidth;

	void Start()
	{
		loadStage(Define.STAGE_1_PATH);

		// test
		Debug.Log("Height = " + stageHeight + ", Width = " + stageWidth);
		Debug.Log(stageMapData[2, 7]); // 1
	}

	/// <summary>
	/// ステージロード機能
	/// </summary>
	/// <param name="path">Defineでステージのパスを指定</param>
	void loadStage(string path)
	{
		StreamReader sr = new StreamReader(Application.dataPath + path);
		string stringStream = sr.ReadToEnd();
		System.StringSplitOptions option = StringSplitOptions.RemoveEmptyEntries;

		// 行分け
		string[] lines = stringStream.Split(new char[] { '\r', '\n' }, option);
		// カンマ区切り
		char[] commaSplit = new char[1] { ',' };

		// 行数設定
		stageHeight = lines.Length;
		// 列数設定
		stageWidth = lines[0].Split(commaSplit, option).Length;

		stageMapData = new int[stageHeight, stageWidth];

		for (int i = 0; i < stageHeight; i++)
		{
			for (int j = 0; j < stageWidth; j++)
			{
				// カンマ分け
				string[] readData = lines[i].Split(commaSplit, option);
				// 型変換
				stageMapData[i, j] = int.Parse(readData[j]);

				// オブジェクト生成
				createObj(stageMapData[i, j], j, i);
			}
		}
	}

	/// <summary>
	/// オブジェクト生成
	/// </summary>
	/// <param name="id">オブジェクトID</param>
	/// <param name="x">マップ配列でのx座標</param>
	/// <param name="z">マップ配列でのz座標</param>
	void createObj(int id, int x, int z)
	{
		switch (id)
		{
			case Define.WALL_ID:
				GameObject wall = Instantiate(wallObj);
				float xpos = ToWorldX(x);
				float zpos = ToWorldZ(z);
				wall.transform.localScale = new Vector3(2, 2, 2);
				wall.transform.position = new Vector3(xpos, 1, zpos);
				break;
			case Define.NONE_ID:
				break;
			case Define.PLAYER_START_POS_ID:
				break;
			default:
				break;
		}
	}

	private float ToWorldX(int xgrid)
	{
		return xgrid * 2;
	}

	private float ToWorldZ(int zgrid)
	{
		return zgrid * 2;
	}

	private int ToGridX(float xworld)
	{
		return Mathf.FloorToInt(xworld / 2);
	}

	private int ToGridZ(float zworld)
	{
		return Mathf.FloorToInt(zworld / 2);
	}
}