using System.Collections;
using UnityEngine;
using System.Collections;

public class record_audio : MonoBehaviour
{
	bool micConnnected = false;
	int minFreq, maxFreq;

	AudioSource goAudioSource;

	void Start()
	{
		//查询机器上有无麦克风
		if (Microphone.devices.Length <= 0)
		{
			Debug.LogWarning("no Microphone");
		}
		else
		{
			micConnnected = true;

			Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);
			if (minFreq == 0 &&    maxFreq == 0)
			{
				maxFreq = 44100;
			}

			goAudioSource = GetComponent<AudioSource>();
		}
	}


	void OnGUI()
	{
		if (micConnnected)
		{

			if (!Microphone.IsRecording (null)) {

				if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 + 500, 300, 80), "Record")) {

					goAudioSource.clip = Microphone.Start (null, true, 20, maxFreq);
				}
			} 
			else 
			{
				if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Stop and play")) 
				{
					Microphone.End (null);

					goAudioSource.Play ();
				}

				GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 25, 200, 50), "Microphone is using...");
			}
		}
	}
}
