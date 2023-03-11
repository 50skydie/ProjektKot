using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour {
    public AgentHandler agentHandler;

    public bool CheckEventStartParameters(MapEvent _mapEvent) {
        if (!agentHandler.ReturnActiveAgent().ReturnIfBusy()) {
            if (agentHandler.ReturnActiveAgent().ReturnEventTypeList().Contains(_mapEvent.returnEventType())) {
                Debug.Log("event type and agent type are correct");
                return true;
                //StartEvent(mapEvent.eventInitialTimer, agentHandler.ReturnActiveAgent().workingSpeed);
            }
        }
        Debug.Log("Ni chuja");
        return false;
    }

    public void StartEvent(int initialMapEventTimer, float agentWorkingSpeed) {

    }
}
