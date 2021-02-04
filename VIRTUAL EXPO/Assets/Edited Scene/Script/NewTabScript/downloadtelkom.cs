using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class downloadtelkom : MonoBehaviour
{

	public void DownloadTelkom1()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1Up-_Hn7lFaGEghiH8I5JHFNjuckQ73W9&export=download");
		#endif
	}

	public void DownloadTelkom2()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1rqi8b8yYHQ9oAjRgRgKD8HJfljQmx5vW&export=download");
		#endif
	}

	public void DownloadTelkom3()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=15s7u9BsBE70M6tyWtYGsepBZCC_wYw9G&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}