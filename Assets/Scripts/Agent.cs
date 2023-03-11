using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public enum AnimalType { Cat, Dog, Bird, Mouse };

public class Agent : MonoBehaviour {
    public float distrust;
    public int maxDistrust;
    [Range(0.0f, 100.0f)]
    public float workingSpeed;
    public AnimalType animalType;
    public List<string> eventTypeList = new() { "Search", "Extract", "Explore", "Storyline" };
    public bool isBusy;
    public Image animalImage; //or Sprite dataType?
    public AgentHandler agentHandler;

    private void Awake() {
        agentHandler = this.gameObject.GetComponentInParent<AgentHandler>();
    }

    public void ChooseAgent() { //on button click
        agentHandler.SetActiveAgent(this.gameObject.GetComponent<Agent>());
    }

    public List<string> ReturnEventTypeList() {
        if (animalType == AnimalType.Cat) {
            return (new() { "Search", "Extract", "Storyline" });
        }
        if (animalType == AnimalType.Dog) {
            return (new() { "Search", "Extract" });
        }
        if (animalType == AnimalType.Bird) {
            return (new() { "Search" });
        }
        if (animalType == AnimalType.Mouse) {
            return (new() {"Extract" });
        }
        return null;
    }
}
