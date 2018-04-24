using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDelegateHandler : MonoBehaviour {

	public delegate void BroadcastEvent();
	public event BroadcastEvent OnSetScore;
	public event BroadcastEvent OnGetScore;

	public delegate void BroadcastMessage(string message);
	public event BroadcastMessage OnShareStatus;

	void Start(){

		if(OnSetScore != null)
			OnSetScore();
		
		if(OnGetScore != null)
			OnGetScore();

		if(OnShareStatus != null)
			OnShareStatus("Ini statusnya");
	}

	void Init(){

	}

}
