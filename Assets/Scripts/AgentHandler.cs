using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour {
    public EventHandler eventHandler;
    public List<Agent> agentList;
    public Agent activeAgent;

    private void Awake() {
        foreach (Agent _agent in this.gameObject.GetComponentsInChildren<Agent>() ){
            agentList.Add(_agent);
        }
    }

    public void SetActiveAgent (Agent _agent) {
        activeAgent = _agent;
    }

    public Agent ReturnActiveAgent() {
        return (activeAgent);
    }

    public void CheckIfRemoveAgent (Agent _agent) {
        if (_agent.ReturnDistrust() >= _agent.ReturnMaxDistrust()) {
            agentList.Remove(_agent);
            Destroy(_agent.gameObject);
        }
    }

    public void AddNewAgent (Agent _agent) {
        agentList.Add(_agent);
        //create gameobject with this._agent script on it
    }
}
