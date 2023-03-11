using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using TMPro;

public class AgentHandler : MonoBehaviour {
    public EventHandler eventHandler;
    public List<Agent> agentList;
    public Agent activeAgent;
    public GameObject agentUiTemplate;
    public GameObject uiRootGameObject;

    private void Awake() {
        foreach (Agent _agent in this.gameObject.GetComponentsInChildren<Agent>() ){  //fill data on Awake with given test agents
            agentList.Add(_agent);
            CreateUiButton(_agent);
        }
    }

    public void SetActiveAgent (Agent _agent) {  //set tracking agent
        Debug.Log("SetActiveAgent = " + _agent);
        activeAgent = _agent;
    }

    public Agent ReturnActiveAgent() {  //return tracking agent
        return (activeAgent);
    }

    public void CheckIfRemoveAgent (Agent _agent) {  //remove given agent from list then agent's ui button and gameobject
        if (_agent.ReturnDistrust() >= _agent.ReturnMaxDistrust()) {
            agentList.Remove(_agent);
            RemoveUiButton(_agent);
            Destroy(_agent.gameObject);
        }
    }

    public void AddNewAgent (Agent _agent) {  //add new agent tbd
        agentList.Add(_agent);
    }

    public void CreateUiButton(Agent _agent) { //Create button from template under root GameObject
        GameObject uiAgentObject = Instantiate(agentUiTemplate);
        uiAgentObject.transform.SetParent(uiRootGameObject.transform);
        uiAgentObject.GetComponent<Button>().onClick.AddListener(_agent.ChooseAgent);
        uiAgentObject.GetComponentInChildren<TextMeshProUGUI>().text = _agent.ReturnName();
    }

    public void RemoveUiButton(Agent _agent) {  //go through agent Ui Buttons and compare the name then delete
        foreach (int childId in Enumerable.Range(0, uiRootGameObject.transform.childCount)){
            if(uiRootGameObject.transform.GetChild(childId).GetComponentInChildren<TextMeshProUGUI>().text == _agent.ReturnName()) {
                Destroy(uiRootGameObject.transform.GetChild(childId).gameObject);
            }
        }
    }
}
