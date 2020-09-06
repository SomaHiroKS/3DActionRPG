﻿using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StageReader : MonoBehaviour {

	TextAsset csvFile; // CSVファイル
	List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;

	void Start()
	{
		csvFile = Resources.Load("Stage1") as TextAsset; // Resouces下のCSV読み込み
		StringReader reader = new StringReader(csvFile.text);

		// , で分割しつつ一行ずつ読み込み
		// リストに追加していく
		while (reader.Peek() != -1) // reader.Peaekが-1になるまで
		{
				string line = reader.ReadLine(); // 一行ずつ読み込み
				csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
		}

		Debug.Log(csvDatas[0][1]); 

	}
}