using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject keySlot;
    [SerializeField] GameObject noKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (keySlot.activeSelf == true)
            {
                keySlot.SetActive(false);
                Destroy(gameObject);
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (keySlot.activeSelf == false)
            {
                noKey.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        noKey.SetActive(false);
    }

    void MoveDoor()
    {

    }
}
