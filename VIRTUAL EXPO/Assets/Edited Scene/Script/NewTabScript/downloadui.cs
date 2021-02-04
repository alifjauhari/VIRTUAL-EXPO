using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class downloadui : MonoBehaviour
{

	public void DownloadUI1()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1dmaTVKHEH4358n2twpkwIdjlzjsH4R54&export=download");
		#endif
	}

	public void DownloadUI2()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1eBDE1NlJNG7S1xbuntUEYzKU7aIF_k6s&export=download");
		#endif
	}

	public void DownloadUI3()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1UX69QezxtQUmTSSf8VEABgJmJmAAaxin&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}