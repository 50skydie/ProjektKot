using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EventType { Search, Extract, Explore, Storyline };

public class MapEvent : MonoBehaviour {
    public string eventName = "None";
    public EventHandler eventHandler;
    public EventType eventType;
    public int eventInitialTimer;
    public Image eventImage;
    //public Reward reward - Script that tells other managers what is the reward that depends on reward type?

    public void RequestEventStart() {
        eventHandler.CheckEventStartParameters(this.gameObject.GetComponent<MapEvent>());
    }

    public EventType returnEventType() {
        return eventType;
    }

}
