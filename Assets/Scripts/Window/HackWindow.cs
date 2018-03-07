using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HackWindow : Window {

	public TextMeshProUGUI baseText;
	public List<Transform> wordPositions = new List<Transform>();
	public Image fillBar;
	public float progress;
	public float duration;

}
