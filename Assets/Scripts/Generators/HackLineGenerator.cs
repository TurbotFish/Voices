using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackLineGenerator : MonoBehaviour {

	private static HackLine[] lineList = {
	  //new HackLine("_123456789_123456789_123456789_123456789_",0),
		new HackLine("#sys =os.()",9),
		new HackLine("import socket, sys, os => ",26),
		new HackLine("s.send ('Host:' + sys.argv[0] +  +'/r/n",32),
		new HackLine("[]",1),
	};

	public static HackLine GetRandomLine ()
	{
		int randomIndex = Random.Range(0,lineList.Length);
		HackLine randomLine = lineList[randomIndex];

		return randomLine;
	}
}
