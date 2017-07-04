using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeSprites : MonoBehaviour {
    SpriteRenderer sRenderer;
    public void SetSprite(Sprite sprite, int sortingOrder)
    {
        sRenderer.sprite = sprite;
        sRenderer.sortingOrder = sortingOrder;
    }

    public void SetSprite(Sprite sprite)
    {
        SetSprite(sprite, 0);
    }
    void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
