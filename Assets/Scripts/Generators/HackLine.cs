using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HackLine {

	public string line;
	public int insertIndex;

	public HackLine (string _line, int _insertIndex)
	{
		line = _line;
		insertIndex = _insertIndex;
	}
}
