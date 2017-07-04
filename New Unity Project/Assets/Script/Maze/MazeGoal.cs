using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGoal : MonoBehaviour {
    public Sprite closedGoalSprite;
    public Sprite openedGoalSprite;
    // Use this for initialization
    void Start () {
        GetComponentInChildren<SpriteRenderer>().sprite = closedGoalSprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OpenGoal()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = openedGoalSprite;
    }
  
}
