using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EventType { Search, Extract, Explore, Storyline };

public class MapEvent : MonoBehaviour {
    public string eventName = "None";
    public string eventDescription = "None";
    public EventHandler eventHandler;
    public EventType eventType;
    public int eventInitialTimer;
    public Texture eventTexture;
    //public Reward reward - Script that tells other managers what is the reward that depends on reward type?
    private void Awake() {
        eventHandler = this.gameObject.GetComponentInParent<EventHandler>();
    }

    public void RequestEventStart() {  //on button click
        Debug.Log("RequestEventStart and call CheckEventStartParameters with "+ this.gameObject.GetComponent<MapEvent>());
        eventHandler.CheckEventStartParameters(this.gameObject.GetComponent<MapEvent>());
    }

    public void RequestEventShow() {
        eventHandler.ShowEventInformation(this.gameObject.GetComponent<MapEvent>());
    }

    public string ReturnEventType() {
        return eventType.ToString();
    }

    public string ReturnEventName() {
        return eventName;
    }
    public string ReturnEventDescription()
    {
        return eventDescription;
    }

    public int RetrunEventInitialTimer() {
        return eventInitialTimer;
    }

    public Texture ReturnEventTexture() {
        return eventTexture;
    }
}
