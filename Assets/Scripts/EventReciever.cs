using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReciever : MonoBehaviour {

	public EventDelegateHandler _EventDelegateHandler;

	// Use this for initialization
	void Start () {
		_EventDelegateHandler.OnGetScore += GetScore;
		_EventDelegateHandler.OnSetScore += SetScore;
		_EventDelegateHandler.OnShareStatus += YourStatus;
	}

	void OnDestroy(){
		_EventDelegateHandler.OnGetScore -= GetScore;
		_EventDelegateHandler.OnSetScore -= SetScore;
		_EventDelegateHandler.OnShareStatus -= YourStatus;
	}

	void GetScore(){
		Debug.Log("Get Score");
	}

	void SetScore(){
		Debug.Log("Set Score");
	}

	void YourStatus(string status){
		Debug.Log(status);
	}

}
