using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word  {

	public string word;

	WordDisplay display;

	int typeIndex;

	public Word (string _word, WordDisplay _display)
	{
		word = _word;
		typeIndex = 0;
		display = _display;
		display.SetWord (word);
	}

	public char GetNextLetter()
	{
		return word[typeIndex];
	}

	public void TypeLetter()
	{
		typeIndex ++;
		display.HighlightWord(0,typeIndex);
	}

	public void EraseLetter()
	{
		//typeIndex --;
		//highlight the letter that has been erased

	}

	public bool WordTyped()
	{
		bool wordTyped = (typeIndex >= word.Length);
		if(wordTyped)
		{
			//remove the word
		}
		return wordTyped;
	}

	public void Disappear()
	{
		display.gameObject.SetActive (false);
	}
}
