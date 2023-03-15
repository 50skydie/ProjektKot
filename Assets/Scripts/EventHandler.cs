using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using TMPro;


public class EventHandler : MonoBehaviour {
    public AgentHandler agentHandler;
    public bool ifShowEventInfo;
    public GameObject mapUiEventInfo;

    private void Awake() {
        ifShowEventInfo = false;
    }

    public bool CheckEventStartParameters(MapEvent _mapEvent) {
        if (!agentHandler.ReturnActiveAgent().ReturnIfBusy()) {
            if (agentHandler.ReturnActiveAgent().ReturnEventTypeList().Contains(_mapEvent.ReturnEventType())) {
                Debug.Log("event type and agent type are correct");
                return true;
                //StartEvent(mapEvent.eventInitialTimer, agentHandler.ReturnActiveAgent().workingSpeed);
            }
        }
        Debug.Log("Ni chuja");
        return false;
    }

    //public void showEventInformation  - show mission panel and allow to choose agent
    public void ShowEventInformation(MapEvent _mapEvent) {
        ifShowEventInfo = !ifShowEventInfo;
        if (ifShowEventInfo) {  //setup dynamicaly parameters in UI
            mapUiEventInfo.SetActive(true);
            //fill text data
            foreach (TextMeshProUGUI mapEventText in mapUiEventInfo.GetComponentsInChildren<TextMeshProUGUI>()) {
                if (mapEventText.text == ".MapEventName.") {
                    mapEventText.text = _mapEvent.ReturnEventName();
                } 
                if (mapEventText.text == ".MapEventDecription.") {
                    mapEventText.text = _mapEvent.ReturnEventDescription();
                }
                if (mapEventText.text == ".MapEventType.")
                {
                    mapEventText.text = "Event Type: "+ _mapEvent.ReturnEventType();
                }
            }
            //fetch image
            mapUiEventInfo.GetComponentInChildren<RawImage>().texture = _mapEvent.ReturnEventTexture();

        } else {
            mapUiEventInfo.SetActive(false);
        }
    }
}
