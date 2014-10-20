// 作者 井口 慧亮
// ファイル名 End.cs
// 概要
// 終了処理の記述
// 
// 更新情報
// 10月12日作成

using UnityEngine;
using System.Collections;

public class End : MonoBehaviour 
{
	// 前準備部
	public float fNextTime = 10.0f; 		// 遷移時間
	public float fFlahsSpeed = 1.0f; 		// 点滅スピード


	private float fFlash;					// 点滅処理用
	private bool bPushFlag;  				// 押されたフラグ
	private int nScore; 
	private int nHighScore; 

	// PlayerPrefsで保存するためのキー
	private const string HighScoreKey = "HighScore";
	private const string ScoreKey = "Score";
	
	// Use this for initialization
	void Start() 
	{
		// GAME　シーンで保存したスコアとハイスコアを取得
		nHighScore = PlayerPrefs.GetInt (HighScoreKey);
		nScore = PlayerPrefs.GetInt (ScoreKey);
		bPushFlag = false;
	}
	
	// Update is called once per frame
	void Update() 
	{
		// シーン遷移処理
		if(Input.GetKey(KeyCode.Return)){
			bPushFlag = true;
		}
		if(bPushFlag)
		{
			fNextTime -= Time.deltaTime;
			if(fNextTime <= 0.0f){	
				Application.LoadLevel("TITLE"); // 経過時間後移動
			}
		}
	}
	
	void OnGUI()
	{
		TextMesh Tm;
		GameObject text;

		text = GameObject.Find("ScoreText");
		Tm = text.GetComponent<TextMesh>();
		Tm.text = string.Copy("SCORE :" + nScore);

		text = GameObject.Find("HIScoreText");
		Tm = text.GetComponent<TextMesh>();
		Tm.text = string.Copy("HIGH SCORE :" + nScore);
	

		text = GameObject.Find("EndMessage");
		Tm = text.GetComponent<TextMesh>();
		float fAlpha; // アルファ値反映用
		fAlpha = Mathf.Sin ((fFlash += fFlahsSpeed) * (Mathf.PI / 180.0f));
		Tm.color = new Color(Tm.color.r, Tm.color.g, Tm.color.b, 255.0f * fAlpha);
		//Tm.text = string.Copy("GAME OVER");
	



			

	}
}
