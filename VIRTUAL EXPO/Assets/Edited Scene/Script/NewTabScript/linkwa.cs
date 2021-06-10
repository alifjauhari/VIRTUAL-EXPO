using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkwa : MonoBehaviour 
{
	public void Andry1_36()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/62811200412");
		#endif
	}

	public void Fathah3()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628122493458");
		#endif
	}

	public void Fajar4()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281221825960");
		#endif
	}

	public void Yanuar7()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6282219331921");
		#endif
	}

	

	public void Maman10_11()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281321397936");
		#endif
	}

	public void Idola12()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6285294258565");
		#endif
	}

	public void Agus13_14()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281320447817");
		#endif
	}

	public void Luciana15()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628122345456");
		#endif
	}

	public void Rohmat16()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628112007132");
		#endif
	}

	public void Rosad17()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281320720093");
		#endif
	}

	public void Wiyono18()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628122358932");
		#endif
	}

	public void Ahmad19()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281320429546");
		#endif
	}

	public void Angga20_31_37()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281316216187");
		#endif
	}

	public void Doan21_22()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/62811101027");
		#endif
	}

	public void Erwin23()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6282121514878");
		#endif
	}

	public void Khoirul24()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628121616461");
		#endif
	}

	public void Ary25_26()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281214382436");
		#endif
	}

	public void Zakiyullah27()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281221069867");
		#endif
	}

	public void Willy28()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281330636823");
		#endif
	}

	public void Simon29()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/628562378687");
		#endif
	}

	public void Asep30()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6285222169687");
		#endif
	}

	public void AzamZamhuri32()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6287730000207");
		#endif
	}

	public void Satria34()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6282120481404");
		#endif
	}

	/*public void Aloysius35()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/62856972584");
		#endif
	}
	nomor telepon bukan nomor whatsapp*/

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}