using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkemail : MonoBehaviour 
{
	public void Andry1_36()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=andrya@telkomuniversity.ac.id");
		#endif
	}

	public void Fathah3()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=kotaksurat@fathah.net");
		#endif
	}

	public void Fajar4()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=fajarciptandi@telkomuniversity.ac.id");
		#endif
	}

    public void Widia6()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=widianur@telkomuniversity.ac.id");
		#endif
	}

	public void Yanuar7()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=yanuarh@telkomuniversity.ac.id");
		#endif
	}


	public void Maman10_11()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=abdurohman@telkomuniversity.ac.id");
		#endif
	}


	public void Agus13_14()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=guskus@telkomuniversity.ac.id");
		#endif
	}

	public void Luciana15()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=lucianawina@gmail.com ");
		#endif
	}

	public void Rohmat16()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=roja2128@gmail.com");
		#endif
	}

	public void Rosad17()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=rosadmeh2014@gmail.com");
		#endif
	}

	public void Wiyono18()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=wiyono@telkomuniversity");
		#endif
	}

	public void Ahmad19()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=sugianaa@telkomuniversity.ac.id");
		#endif
	}

	public void Angga20_31_37()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=anggarusdinar@telkomuniversity.ac.id");
		#endif
	}

	public void Doan21_22()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=doanperdana@telkomuniversity.ac.id");
		#endif
	}

	public void Erwin23()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=erwinelektro@telkomuniversity.ac.id");
		#endif
	}

	public void Khoirul24()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=anwarkhoirul@telkomuniversity.ac.id");
		#endif
	}

	public void Ary25_26()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=arymurti@telkomuniversity.ac.id");
		#endif
	}

	public void Zakiyullah27()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=zakiyullah@telkomuniversity.ac.id");
		#endif
	}

	public void Willy28()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=waczze@telkomuniversity.ac.id");
		#endif
	}

	public void Simon29()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=simon.siregar@tass.telkomuniversity.ac.id");
		#endif
	}

	public void Asep30()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=krackers@telkomuniversity.ac.id");
		#endif
	}


	public void Satria34()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=satriamandala@telkomuniversity.ac.id");
		#endif
	}

	public void Aloysius35()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=pramuditaadya@telkomuniversity.ac.id");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}