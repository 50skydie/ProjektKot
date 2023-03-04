using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour {
    public List<Agent> agentList;

    private void Awake() {
        foreach (Agent agent in this.gameObject.GetComponentsInChildren<Agent>() ){
            agentList.Add(agent);
        }
    }

    private void RemoveAgent () {

    }

    private void CheckIfAgentOwnerIsInHome() {

    }
}
