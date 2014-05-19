using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,10,100,20),"Персонаж"))
	   {
			Application.OpenURL("ya.ru");
		}
	}
}
