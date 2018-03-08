using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;

	Word activeWord;
	bool hasActiveWord;


	public HackWindow activeHackWindow;
	public string wordKey;

	public enum Context {hack,dialog}
	public Context context;

	/*public void AddWord(Vector2 pos)
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord(pos));
		words.Add(word);
	}*/

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		}
		else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			if (context == Context.hack) {
				if (activeWord.word == wordKey) {
					activeHackWindow.Close ();
				}
				activeWord.Disappear ();
			}

			hasActiveWord = false;
			words.Remove(activeWord);
		}
	}

	public void EraseLetter ()
	{
		if (hasActiveWord)
		{
			activeWord.EraseLetter ();
		}


		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
			if (context == Context.hack) {

			}
		}
	}


}
