using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordDisplay : MonoBehaviour {

	public TextMeshPro text;


	public void SetWord (string word)
	{
		text.text = word;
	}
}
