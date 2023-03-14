using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour {
    public GameObject present;
    private void OnTriggerEnter2D(Collider2D other) {
        Score.score++;
        DropPresent();
    }

    private void DropPresent() {
        var santaPosition = GameObject.Find("Santa").transform.position;
        var instantiatedPresent = Instantiate(present, santaPosition, Quaternion.identity);
        Destroy(instantiatedPresent, 15);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
