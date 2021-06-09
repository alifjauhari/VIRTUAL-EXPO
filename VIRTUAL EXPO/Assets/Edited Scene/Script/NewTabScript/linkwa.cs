using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkwa : MonoBehaviour 
{

	public void AzamZamhuri32()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6287730000207");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}