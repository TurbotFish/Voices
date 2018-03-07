using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HackWindow : Window {

	public TextMeshProUGUI baseText;
	public List<Transform> wordPositions = new List<Transform>();
	public Image fillBar;
	public bool inProgress;
	public float progress;
	public TextMeshProUGUI percentage;
	public float duration;
	public string wordKey;
	public List<Word> words = new List<Word>();


	void Update ()
	{
		if (inProgress)
		{
			Progress();
		}

		if (progress >= 1)
		{
			inProgress = false;
			SendCompleteMessage();
		}
	}

	void Progress ()
	{
		progress += (1/duration)*Time.deltaTime;
		fillBar.fillAmount = progress;
		int perc = Mathf.FloorToInt(progress*100);
		percentage.text = perc.ToString() + " %";
	}

	void SendCompleteMessage()
	{
		Debug.Log("you've been hacked");
	}
}
