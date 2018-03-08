using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LineLink {

	public Word word;
	public string link;

	public LineLink (Word _word, string _link)
	{
		word = _word;
		link = _link;
	}

}
