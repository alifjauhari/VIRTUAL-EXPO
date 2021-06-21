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
	
	public void Link2()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/H8lIkgymOak");
		#endif
	}
	
	public void Link3()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/oemzXKSZ9No");
		#endif
	}
	
	public void Link5()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/y_uAmox2yc8");
		#endif
	}
	
	public void Link7()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/tyAVisXj0mc");
		#endif
	}
	
	public void Link14()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/r9UrtwmGYF0");
		#endif
	}

	public void Link17()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/cX4x5NfrgpI");
		#endif
	}

	public void Link20()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/HzPzQ0HxfSQ");
		#endif
	}
	
	public void Link21()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/3-dz8poCaHQ");
		#endif
	}
	
	public void Link22()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/_DJg-uUJMJc");
		#endif
	}
	
	public void Link24()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/cz0raz5-Iec");
		#endif
	}
	
	public void Link25()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/dxtvDBWq3UI");
		#endif
	}
	
		public void Link28()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/_1EmTWwGsKc");
		#endif
	}
	
		public void Link29()
	{
		#if !UNITY_EDITOR
		openWindow(" https://youtu.be/Nmca26UPnxc");
		#endif
	}
	
		public void Link30()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/B4JPE_PAxRQ");
		#endif
	}
	
		public void Link31()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/MryGaJyOiC4");
		#endif
	}
	
		public void Link32()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/zzoBVXlEbO0");
		#endif
	}
	
		public void Link36()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/YL4pVD4Lr8c");
		#endif
	}
	
		public void Link38()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/VpIIJ8fRCp0");
		#endif
	}
	
		public void Link39()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/GtKCzqEvKk0");
		#endif
	}
	
		public void Link42()
	{
		#if !UNITY_EDITOR
		openWindow("https://youtu.be/H6t2aKAykO8");
		#endif
	}



	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}