using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackLineGenerator : MonoBehaviour {

	private static HackLine[] lineList = {
	  //new HackLine("_123456789_123456789_123456789_123456789_",0),
		new HackLine("#sys =os.()",9),
		new HackLine("import socket, sys, os => ",26),
		new HackLine("s.send ('Host:' + sys.argv[0] +  +'/r/n",32),
		new HackLine("'Project':  => origin",10),
		new HackLine("//_error : _ (?)",12),
		new HackLine("[]",1)
	};

	public static string[] wordList = {"abort","bypass","clone","defend","erase","fork","ghost","handle","initiate","loop","merge","protect","reroute","save","turtle","uncover","verify","wipe","zero"};

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0,wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}


	public static HackLine GetRandomLine (string word)
	{
		int randomIndex = Random.Range(0,lineList.Length);
		//HackLine randomLine = lineList[randomIndex];
		HackLine randomLine = new HackLine(lineList[randomIndex].line,lineList[randomIndex].insertIndex);
		randomLine.line = randomLine.line.Insert(randomLine.insertIndex,word);
		return randomLine;
	}


}
