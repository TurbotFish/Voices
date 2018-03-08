using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogLine {

	public string line;
	public List<string> lines = new List<string> ();
	public List<float> timesBetweenLines = new List<float> ();
	public string id;
	public List<LineLink> lineLinks = new List<LineLink>();

	public DialogLine (string _line, string _id, List<LineLink> _lineLinks)
	{
		line = _line;
		id = _id;
		lineLinks = _lineLinks;
	}
}
