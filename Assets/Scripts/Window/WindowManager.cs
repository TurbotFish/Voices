using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour {

	public List<GameObject> windows = new List<GameObject>();
	public GameObject activeWindow;
	bool hasActiveWindow;

	public void OpenWindow(int i)
	{
		windows [i].SetActive (true);
		activeWindow = windows [i];
		hasActiveWindow = true;

	}
	public void CloseActiveWindow()
	{
		activeWindow.SetActive (false);
		hasActiveWindow = false;
	}
}
