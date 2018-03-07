using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour {

	//public HackLineGenerator hackGenerator;
	public WordSpawner wordSpawner;
	public WordManager wordManager;
	public List<Window> windows = new List<Window>();
	public List<HackWindow> hackWindows = new List<HackWindow>();
	public HackWindow hackWindowPrefab;
	public Window activeWindow;
	bool hasActiveWindow;

	//DEBUG
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CreateHackWindow(11, Vector3.zero);
		}
	}
	//DEBUG


	public void OpenWindow(int i)
	{
		windows [i].gameObject.SetActive (true);
		activeWindow = windows [i];
		hasActiveWindow = true;
	}

	public void CloseActiveWindow()
	{
		activeWindow.gameObject.SetActive (false);
		hasActiveWindow = false;
	}

	public void CloseHackWindow(int index)
	{
		hackWindows[index].gameObject.SetActive(false);
	}

	public void CreateHackWindow(int lineCount, Vector3 pos)
	{
		HackWindow window = Instantiate(hackWindowPrefab, pos, Quaternion.identity);

		List<string> words = new List<string>();
		foreach(string word in HackLineGenerator.wordList)
		{
			words.Add(word);
		}


		List<int> posIndexes = new List<int>{0,1,2};

		//Word Key
		int wordIndex = Random.Range(0,words.Count);
		int posIndex = Random.Range(0,posIndexes.Count);
		Word wordKey = new Word(words[wordIndex],wordSpawner.SpawnWord(window.wordPositions[posIndexes[posIndex]].position, window.wordPositions[posIndexes[posIndex]], true));
		words.RemoveAt(wordIndex);
		posIndexes.RemoveAt(posIndex);
		//Word A
		wordIndex = Random.Range(0,words.Count);
		posIndex = Random.Range(0,posIndexes.Count);
		Word wordA = new Word(words[wordIndex],wordSpawner.SpawnWord(window.wordPositions[posIndexes[posIndex]].position, window.wordPositions[posIndexes[posIndex]], true));
		words.RemoveAt(wordIndex);
		posIndexes.RemoveAt(posIndex);
		//Word B
		wordIndex = Random.Range(0,words.Count);
		posIndex = Random.Range(0,posIndexes.Count);
		Word wordB = new Word(words[wordIndex],wordSpawner.SpawnWord(window.wordPositions[posIndexes[posIndex]].position, window.wordPositions[posIndexes[posIndex]], true));
		words.RemoveAt(wordIndex);
		posIndexes.RemoveAt(posIndex);


		int lineKeyIndex = Random.Range(0,lineCount);

		window.baseText.text = "";

		for (int i = 0; i < lineCount; i++)
		{
			string addedString = "";

			if (i == lineKeyIndex)
			{
				addedString = HackLineGenerator.GetRandomLine(wordKey.word).line;
			}
			else
			{
				
				addedString = HackLineGenerator.GetRandomLine(words[Random.Range(0,words.Count)]).line;
			}

			window.baseText.text = window.baseText.text +"\n" +addedString;
		}

		window.words.Add(wordKey);
		window.words.Add(wordA);
		window.words.Add(wordB);
		window.wordKey = wordKey.word;

		FocusOnHackWindow (window);
	}

	public void FocusOnHackWindow (HackWindow window)
	{
		hasActiveWindow = true;
		activeWindow = window;
		wordManager.words.Clear ();
		foreach (Word word in window.words) {
			wordManager.words.Add (word);
		}

	
	}
}
