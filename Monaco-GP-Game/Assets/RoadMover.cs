using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    [SerializeField] RoadManager roadManager;
    
    
    private void OnEnable() {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        roadManager = gameController.GetComponent<RoadManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * roadManager.roadPassingSpeed);
    }
}
