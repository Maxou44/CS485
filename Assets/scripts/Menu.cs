﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public int buttonWidth;
	public int buttonHeight;
	private int origin_x;
	private int origin_y;

	// Use this for initialization
	void Start () {
		buttonWidth = 200;
		buttonHeight = 50;
		origin_x = Screen.width / 2 - buttonWidth / 2;
		origin_y = Screen.height / 2 - buttonHeight * 2;
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Roll-a-ball tutorial"))
		{
			Application.LoadLevel(1);
		}
		if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 10, buttonWidth, buttonHeight), "The Londonner Dad"))
		{
			Application.LoadLevel(2);
		}
		if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 2 + 30, buttonWidth, buttonHeight), "Exit"))
		{
			#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
			#else
				Application.Quit();
			#endif
		}
	}
}










