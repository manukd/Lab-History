using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeDirective : MonoBehaviour {
    public int keysToFind;
    public Text keysValueText;
    public MazeGoal mazeGoalPrefab;
    public MazeKey mazeKeyPrefab;
  
    MazeGoal mazeGoal;
    int foundKeys;
    List<Vector3> mazeKeyPositions;

    public delegate void MazeReadyAction();
    public static event MazeReadyAction OnMazeReady;
    // Use this for initialization
    void Start () {
        if (OnMazeReady != null)
        {
            OnMazeReady();
        }
    }
    void Awake()
    {
        MazeGenerator.OnMazeReady += StartDirectives;
    }

    void StartDirectives()
    {
        mazeGoal = Instantiate(mazeGoalPrefab, MazeGenerator.instance.mazeGoalPosition, Quaternion.identity) as MazeGoal;
        mazeGoal.transform.SetParent(transform);

        mazeKeyPositions = MazeGenerator.instance.GetRandomFloorPositions(keysToFind);

        for (int i = 0; i < mazeKeyPositions.Count; i++)
        {
            MazeKey mazeKey = Instantiate(mazeKeyPrefab, mazeKeyPositions[i], Quaternion.identity) as MazeKey;
            mazeKey.transform.SetParent(transform);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
