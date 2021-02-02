using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class download : MonoBehaviour
{

	public void OpenLinkJSPlugin()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1R-k7rbV6vm_56MeULAt0zs6yFB69sIIL&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}