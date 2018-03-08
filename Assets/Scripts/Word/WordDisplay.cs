using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordDisplay : MonoBehaviour {

	public TextMeshPro text;
	public string highlightOn, highlightOff;
	string wordSave;

	public void SetWord (string word)
	{
		text.text = word;
		wordSave = word;
	}

	public void HighlightWord(int charOn, int charOff)
	{
		text.text = wordSave.Insert (charOn, highlightOn);
		text.text = text.text.Insert (charOff+highlightOn.Length, highlightOff);
	}

	public void ClearHighlight()
	{
		text.text = text.text.Replace (highlightOn,"");
		text.text = text.text.Replace (highlightOff,"");
	}
}
