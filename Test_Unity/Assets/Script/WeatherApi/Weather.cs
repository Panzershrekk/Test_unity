using UnityEngine;
using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Networking;

public class Weather : MonoBehaviour
{
	public int weatherState = 0;

	private UnityWebRequest www;
	private string url = "http://api.openweathermap.org/data/2.5/forecast?id=6454414&APPID=5f59a9280896efe5efa1886139213c21";
   
	void Start() // Use this for initialization
    {
		www = new UnityWebRequest(url);
		StartCoroutine(GetText());
    }

	IEnumerator GetText() 
	{
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
 
        if(www.isNetworkError)
            Debug.Log(www.error);
        else 
		{
            string result = www.downloadHandler.text;
			_Particle fields = JsonUtility.FromJson<_Particle>(result);
			string currentWeather = fields.list[0].weather[0].main;
			if (currentWeather == "Clouds")
				weatherState = 1;
			else if (currentWeather == "Rain")
				weatherState = 2;
			else if (currentWeather == "Clear")
				weatherState = 3;
        }
    }
	
	[System.Serializable]
	public class _weather
	{
		public string main;
	}
	
	[System.Serializable]
	public class _list
	{
		public _weather[] weather;
	}
	
	[System.Serializable]
	public class _Particle
	{
		public _list[] list;
		public string cod;
	}
}