// 作者 井口 慧亮
// ファイル名 Title.cs
// 概要
// タイトル処理の記述
// 
// 更新情報
// 10月12日作成

using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour 
{
	// 前準備部
	public float fNextTime = 10.0f; 		// 遷移時間
	public float fFlahsSpeed = 1.0f; 		// 点滅スピード

	private float fFlash;					// 点滅処理用
	private bool bPushFlag;  				// 押されたフラグ

	// Use this for initialization
	void Start() 
	{
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
				Application.LoadLevel("GAME"); // 経過時間後移動
			}
		}
	}

	// 
	void OnGUI()
	{	
		TextMesh Tm;
		GameObject text;

		text = GameObject.Find("TitleMessage");
		Tm = text.GetComponent<TextMesh>();
		float fAlpha; // アルファ値反映用
		fAlpha = Mathf.Sin ((fFlash += fFlahsSpeed) * (Mathf.PI / 180.0f));
		Tm.color = new Color(Tm.color.r, Tm.color.g, Tm.color.b, 255.0f * fAlpha);
		//Tm.text = string.Copy("TITLE");
	}
}
