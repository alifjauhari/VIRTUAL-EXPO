using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkITB : MonoBehaviour 
{

	public void Link1()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/Win08wPjybE");
		#endif
	}

	public void Link17()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/H8lIkgymOak");
		#endif
	}

	public void Link2()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/cX4x5NfrgpI");
		#endif
	}

	public void Link20()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/XNgUQ-Hyf9I");
		#endif
	}


	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}