using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkITB : MonoBehaviour 
{

	public void OpenLinkJSPlugin()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.youtube.com/watch?v=V4B82wgFc_U");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}