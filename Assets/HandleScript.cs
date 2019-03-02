using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleScript : MonoBehaviour {

    public Sprite[] textures;
    private Sprite chosenTexture;

    // Use this for initialization
    void Start()
    {
        chosenTexture = textures[Random.Range(0, textures.Length)];
        this.GetComponent<SpriteRenderer>().sprite = chosenTexture;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
