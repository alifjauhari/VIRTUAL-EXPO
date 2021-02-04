using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class downloadugm : MonoBehaviour
{

	public void DownloadUGM1()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=12u0AV-UxjQBplwFUjn_97gI_M_m7d70Z&export=download");
		#endif
	}

	public void DownloadUGM2()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1oOSzO4w28EW27UAzQIOFYz8AdXy-gPT6&export=download");
		#endif
	}

	public void DownloadUGM3()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1wmd3MO8EwBoyXXhdsAkS8QQUPiw9MlWR&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}