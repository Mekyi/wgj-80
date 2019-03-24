using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject virtualCamera;
    public bool gameCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) || gameCompleted)
        {
            virtualCamera.SetActive(false);
        }
        else
        {
            virtualCamera.SetActive(true);
        }
    }

    public void GameCompleted()
    {
        gameCompleted = true;
    }
}
