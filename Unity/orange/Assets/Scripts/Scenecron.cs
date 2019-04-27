using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .SceneManagement ;

public class Scenecron : MonoBehaviour {

	private static Scenecron _instance;
	public static Scenecron instance;

	bool isOnAndroid = false;

	void Awake()
	{
		if (_instance != null && _instance != this) {
			Destroy (gameObject);
			return;
		} 
		else 
		{
			_instance = this;
		}

		instance = _instance;
		DontDestroyOnLoad (this);

		#if UNITY_ANDROID
		isOnAndroid = true;
		Screen.fullscreen = false;
		#endif 
	}

	void OnApplicationPause(bool appPaused)
	{
		if (!isOnAndroid || Application.isEditor) {
			return;
		}

		if (!appPaused) {
			Debug.Log ("Application Resumed");
			StartCoroutine (LoadSceneFromFCM());
		}
		else 
		{
			Debug.Log ("Application Paused");
		}
	}


	IEnumerator LoadSceneFromFCM()
	{
		AndroidJavaClass UnityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject curActivity = UnityPlayer.GetStatic<AndroidJavaObject > ("currentActivity");
		AndroidJavaObject curIntent = curActivity.Call<AndroidJavaObject > ("getIntent");

		string sceneToLoad = curIntent.Call<string> ("getStringExtra", "sceneToOpen");

		Scene curScene = SceneManager.GetActiveScene ();

		if (!string.IsNullOrEmpty (sceneToLoad) && sceneToLoad != curScene.name) 
		{
			Debug.Log ("Loading Scene:" + sceneToLoad);
			Handheld.SetActivityIndicatorStyle (AndroidActivityIndicatorStyle.Large);
			Handheld.StartActivityIndicator ();
			yield return new WaitForSeconds (0f);

			SceneManager.LoadScene (sceneToLoad);
		}
	}

}
