using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Video;


public class Controller : MonoBehaviour {


	public CanvasGroup Splashpage;
	public CanvasGroup User_information;
	public CanvasGroup Level_page;
	public CanvasGroup tell_us_more_page;
	public CanvasGroup Start_canversation;
	public CanvasGroup sub_page;
	public CanvasGroup Exam_page;
	public CanvasGroup Sub_2_page;
	public CanvasGroup Daily_study_page;
	public CanvasGroup chat1_page;
	public CanvasGroup thanks_page;
	public CanvasGroup sub_3_page;
	public CanvasGroup chatting_page;
	public CanvasGroup level_test_page;
	public CanvasGroup test_page;
	public CanvasGroup last_page;
	public CanvasGroup hsk_page;









	public GameObject Sub_video;
	public GameObject Exam_video;
	public GameObject daily_study_video;






	// Use this for initialization
	void Start () {

		Sub_video.SetActive (false);
		Exam_video.SetActive (false);
		daily_study_video.SetActive (false);

	}









	public void splash_Button()
	{
		hideSplashpage();
		showUser_information();

	}

	void hideSplashpage()
	{
		Splashpage.DOFade(0, 0.8f);
		Splashpage.interactable = false;
		Splashpage.blocksRaycasts = false;

	}

	void showUser_information()
	{
		User_information.DOFade(1, 0.8f);
		User_information.interactable = true;
		User_information.blocksRaycasts = true;
	}
















	public void user_information_Button()
	{
		hideUser_information();
		showLevel_page();

	}

	void hideUser_information()
	{
		User_information.DOFade(0, 0.1f);
		User_information.interactable = false;
		User_information.blocksRaycasts = false;

	}

	void showLevel_page()
	{
		Level_page.DOFade(1, 0.1f);
		Level_page.interactable = true;
		Level_page.blocksRaycasts = true;
	}
















	public void level_button()
	{
		hideLevel_page();
		showtell_us_more_page();

	}

	void hideLevel_page()
	{
		Level_page.DOFade(0, 0.1f);
		Level_page.interactable = false;
		Level_page.blocksRaycasts = false;

	}

	void showtell_us_more_page()
	{
		tell_us_more_page.DOFade(1, 0.1f);
		tell_us_more_page.interactable = true;
		tell_us_more_page.blocksRaycasts = true;
	}





	public void level_to_leveltest_button()
	{
		hideLevel_page();
		hidetell_us_more_page ();
		hidehsk_page ();
		showlevel_test_page();

	}

	//void hideLevel_page()
	//{
		//Level_page.DOFade(0, 0.1f);
		//Level_page.interactable = false;
		//Level_page.blocksRaycasts = false;

	//}

	void showlevel_test_page()
	{
		level_test_page.DOFade(1, 0.1f);
		level_test_page.interactable = true;
		level_test_page.blocksRaycasts = true;
	}











	public void level_test_page_submit_button()
	{
		hidelevel_test_page ();
		showhsk_page ();
	}

	void hidelevel_test_page()
	{
		level_test_page.DOFade(0, 0.1f);
		level_test_page.interactable = false;
		level_test_page.blocksRaycasts = false;
	}

	void showhsk_page()
	{
		hsk_page.DOFade(1, 0.1f);
		hsk_page.interactable = true;
		hsk_page.blocksRaycasts = true;
	}



	public void hsk_button()
	{
		hidehsk_page ();
		showLevel_page ();
	}

	void hidehsk_page()
	{
		hsk_page.DOFade(0, 0.1f);
		hsk_page.interactable = false;
		hsk_page.blocksRaycasts = false;
	}

	//void showLevel_page()
	//{
		//Level_page.DOFade(1, 0.1f);
		//Level_page.interactable = true;
		//Level_page.blocksRaycasts = true;
	//}










	public void tell_us_more_button()
	{
		hidetell_us_more_page();
		hidelevel_test_page ();
		hidehsk_page ();
		showStart_canversation();

	}

	void hidetell_us_more_page()
	{
		tell_us_more_page.DOFade(0, 0.1f);
		tell_us_more_page.interactable = false;
		tell_us_more_page.blocksRaycasts = false;

	}

	void showStart_canversation()
	{
		Start_canversation.DOFade(1, 0.1f);
		Start_canversation.interactable = true;
		Start_canversation.blocksRaycasts = true;
	}





	public void start_conversation_button()
	{
		hideStart_canversation();
		showsub_page();

	}

	void hideStart_canversation()
	{
		Start_canversation.DOFade(0, 0.1f);
		Start_canversation.interactable = false;
		Start_canversation.blocksRaycasts = false;

	}

	void showsub_page()
	{
		sub_page.DOFade(1, 0.1f);
		sub_page.interactable = true;
		sub_page.blocksRaycasts = true;
		Sub_video.SetActive (true);
	}












	public void sub_button()
	{
		hidesub_page();
		showExam_page();

	}

	void hidesub_page()
	{
		Sub_video.SetActive (false);
		sub_page.DOFade(0, 0.1f);
		sub_page.interactable = false;
		sub_page.blocksRaycasts = false;

	}

	void showExam_page()
	{
		Exam_video.SetActive (true);
		Exam_page.DOFade(1, 0.1f);
		Exam_page.interactable = true;
		Exam_page.blocksRaycasts = true;

	}















	public void Exam_button()
	{
		hideExam_page();
		showSub_2_page();

	}

	void hideExam_page()
	{
		Exam_video.SetActive (false);
		Exam_page.DOFade(0, 0.1f);
		Exam_page.interactable = false;
		Exam_page.blocksRaycasts = false;

	}

	void showSub_2_page()
	{
		Sub_2_page.DOFade(1, 0.1f);
		Sub_2_page.interactable = true;
		Sub_2_page.blocksRaycasts = true;
	}











	public void daily_button()
	{
		hideSub_2_page();
		showDaily_study_page();

	}

	void hideSub_2_page()
	{
		Sub_2_page.DOFade(0, 0.1f);
		Sub_2_page.interactable = false;
		Sub_2_page.blocksRaycasts = false;

	}

	void showDaily_study_page()
	{
		daily_study_video.SetActive (true);
		Daily_study_page.DOFade(1, 0.1f);
		Daily_study_page.interactable = true;
		Daily_study_page.blocksRaycasts = true;
	}










	public void ready_button()
	{
		hideDaily_study_page();
		showchat1_page();

	}

	void hideDaily_study_page()
	{
		daily_study_video.SetActive (false);
		Daily_study_page.DOFade(0, 0.1f);
		Daily_study_page.interactable = false;
		Daily_study_page.blocksRaycasts = false;

	}

	void showchat1_page()
	{
		chat1_page.DOFade(1, 0.1f);
		chat1_page.interactable = true;
		chat1_page.blocksRaycasts = true;
	}







	public void submit_button()
	{
		hidechat1_page();
		showthanks_page();

	}

	void hidechat1_page()
	{
		chat1_page.DOFade(0, 0.1f);
		chat1_page.interactable = false;
		chat1_page.blocksRaycasts = false;

	}

	void showthanks_page()
	{
		thanks_page.DOFade(1, 0.1f);
		thanks_page.interactable = true;
		thanks_page.blocksRaycasts = true;
	}










	public void thanks_button()
	{
		hidethanks_page();
		showsub_3_page();

	}

	void hidethanks_page()
	{
		thanks_page.DOFade(0, 0.1f);
		thanks_page.interactable = false;
		thanks_page.blocksRaycasts = false;

	}

	void showsub_3_page()
	{
		sub_3_page.DOFade(1, 0.1f);
		sub_3_page.interactable = true;
		sub_3_page.blocksRaycasts = true;
	}












	public void chat_button()
	{
		hidesub_3_page();
		showchatting_page();

	}

	void hidesub_3_page()
	{
		sub_3_page.DOFade(0, 0.1f);
		sub_3_page.interactable = false;
		sub_3_page.blocksRaycasts = false;

	}

	void showchatting_page()
	{
		chatting_page.DOFade(1, 0.1f);
		chatting_page.interactable = true;
		chatting_page.blocksRaycasts = true;
	}









	public void test_button()
	{
		hidesub_3_page();
		hidechatting_page ();
		showtest_page();

	}

	void hidechatting_page()
	{
		chatting_page.DOFade(0, 0.1f);
		chatting_page.interactable = false;
		chatting_page.blocksRaycasts = false;
	}
		

	void showtest_page()
	{
		test_page.DOFade(1, 0.1f);
		test_page.interactable = true;
		test_page.blocksRaycasts = true;
	}











	public void ask_button()
	{
		hidechatting_page();
		showsub_3_page();

	}

	//void hidechatting_page()
	//{
		//chatting_page.DOFade(0, 0.1f);
		//chatting_page.interactable = false;
		//chatting_page.blocksRaycasts = false;
	//}


	//void showsub_3_page()
	//{
		//sub_3_page.DOFade(1, 0.1f);
		//sub_3_page.interactable = true;
		//sub_3_page.blocksRaycasts = true;
	//}













	public void send_answer_button()
	{
		hidetest_page();
		showlast_page();

	}

	void hidetest_page()
	{
		test_page.DOFade(0, 0.1f);
		test_page.interactable = false;
		test_page.blocksRaycasts = false;
	}


	void showlast_page()
	{
		last_page.DOFade(1, 0.1f);
		last_page.interactable = true;
		last_page.blocksRaycasts = true;
	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
