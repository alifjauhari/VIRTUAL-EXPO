using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkITB : MonoBehaviour 
{

	public void OpenLinkITB()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.youtube.com/watch?v=V4B82wgFc_U");
		#endif
	}

	public void OpenLinkTelkom()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.youtube.com/watch?v=LwAQQJbHLxU&t=6s");
		#endif
	}

	public void OpenLinkUGM()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/ueDXnBd7TJo");
		#endif
	}

	public void OpenLinkIPB()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/_7sKzCYoBws");
		#endif
	}

	public void OpenLinkUI()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/FEgH3UbjffA");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}