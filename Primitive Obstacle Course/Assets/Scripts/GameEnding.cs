using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    private GameObject _player;
    private GameSession _session;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        _session = GameObject.Find("Game Session").GetComponent<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == _player)
        {
            Debug.Log("You Won!");
            _session.RestartSesion();
        }
    }
}
