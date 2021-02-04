using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class download : MonoBehaviour
{

	public void DownloadIPB1()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1ZBqLTPMrLlU_ACXU3TsegKaonP8G3SaD&export=download");
		#endif
	}

	public void DownloadIPB2()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1VK21gVWCALXj-IqXLTbsLp7fI5LCURag&export=download");
		#endif
	}

	public void DownloadIPB3()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1Dy8j9Fg0Q_B08k3Z-2MWTfDaNbs_4Dai&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}