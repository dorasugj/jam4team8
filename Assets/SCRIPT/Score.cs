// 作者 井口 慧亮
// ファイル名 Score.cs
// 概要
// 終了処理の記述
// 
// 更新情報
// 10月12日作成


using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	private int nScore; // スコア
	private int nHighScore; // ハイスコア
	
	//public GameObject ScoreGUI;			// タイトルメッセージ　（デバッグ用）
	//public GameObject HiScoreGUI;			// タイトルメッセージ　（デバッグ用）

	private string HighScoreKey = "HighScore";
	private string ScoreKey = "Score";

	void Start ()
	{
		Initialize (); // 初期化
	}

	// 関数名 ScoreUP
	// スコアの加算
	// 引数　int 戻り値 無し
	public void ScoreUP(int nPoint)
	{
		nScore = nScore + nPoint;
	}
	
	void Update ()
	{
		// スコアがハイスコアより大きければ
		if (nHighScore < nScore)
		{
			nHighScore = nScore;
		}

		// スコア・ハイスコアを表示する
		TextMesh Tm;
		GameObject text;
		text = GameObject.Find("ScoreText");
		Tm = text.GetComponent<TextMesh>();
		Tm.text = string.Copy("SCORE :" + nScore);

		text = GameObject.Find("HIScoreText");
		Tm = text.GetComponent<TextMesh>();
		Tm.text = string.Copy("HIGH SCORE :" + nScore);


		//Text = string.Copy("HIGH SCORE : " + nHighScore);
	}
	
	// ゲーム開始前の状態に戻す
	private void Initialize ()
	{
		nScore = 0; // スコアを0に戻す
		nHighScore = PlayerPrefs.GetInt (HighScoreKey, 0);	// ハイスコアを取得 保存されてなければ0を設定
	}
	
	// ポイントの追加
	public void AddPoint (int nPoint)
	{
		nScore += nPoint;
	}
	
	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt (HighScoreKey, nHighScore);
		PlayerPrefs.SetInt (ScoreKey, nScore);
		PlayerPrefs.Save ();
		
		// ゲーム開始前の状態に戻す
		Initialize ();
	}

	// 関数名 GetScore
	// 現在のスコアを取得
	// 引数　無し　戻り値　int 
	public int GetScore()
	{
		return nScore;
	}

}
