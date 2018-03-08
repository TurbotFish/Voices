using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Dialog : ScriptableObject {

	public string dialogName = "New Dialog";
	public List<DialogLine> lines;
}
