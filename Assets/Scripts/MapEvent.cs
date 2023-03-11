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
    private void Awake()
    {
        eventHandler = this.gameObject.GetComponentInParent<EventHandler>();
    }

    public void RequestEventStart() {  //on button click
        eventHandler.CheckEventStartParameters(this.gameObject.GetComponent<MapEvent>());
    }

    public string returnEventType() {
        return eventType.ToString();
    }
}
