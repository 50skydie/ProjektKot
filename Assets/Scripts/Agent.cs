using UnityEngine;
using UnityEngine.UI;

public enum AnimalType { Cat, Dog, Bird, Mouse };

public class Agent : MonoBehaviour {
    public int distrust;
    public int maxDistrust;
    [Range(0.0f, 100.0f)]
    public float workingSpeed;
    public AnimalType animalType;
    public Image animalImage; //or Sprite dataType?
}
