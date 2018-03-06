using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word  {

	public string word;

	int typeIndex;

	public Word (string _word)
	{
		word = _word;
		typeIndex = 0;
	}

	public char GetNextLetter()
	{
		return word[typeIndex];
	}

	public void TypeLetter()
	{
		typeIndex ++;
		//highlight the letter that has been typed

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
}
