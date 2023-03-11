using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour {
    public EventHandler eventHandler;
    public List<Agent> agentList;
    public Agent activeAgent;

    private void Awake() {
        foreach (Agent agent in this.gameObject.GetComponentsInChildren<Agent>() ){
            agentList.Add(agent);
        }
    }

    public void SetActiveAgent (Agent _agent) {
        activeAgent = _agent;
    }

    public Agent ReturnActiveAgent() {
        return (activeAgent);
    }

    private void CheckIfRemoveAgent (Agent _agent) {
        if(_agent.distrust >= _agent.maxDistrust) {
            agentList.Remove(_agent);   
        }
    }
}
