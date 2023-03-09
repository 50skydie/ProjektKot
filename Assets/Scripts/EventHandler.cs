using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour {
    public AgentHandler agentHandler;
    public MapEvent mapEvent;

    public void CheckEventStartParameters(MapEvent _mapEvent) {
        Debug.Log(_mapEvent.returnEventType());
    }
}
