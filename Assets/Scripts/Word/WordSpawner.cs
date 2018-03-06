﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;

	public WordDisplay SpawnWord(Vector2 pos)
	{
		GameObject wordObj = Instantiate (wordPrefab, pos, Quaternion.identity);
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay> ();

		return wordDisplay;
	
	}
}
