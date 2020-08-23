using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        magicNumber = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Red" & i == 100)
        {
            this.gameObject.SetActive(false);
        }
        if(gameObject.tag == "Blue" & i == magicNumber)
        {
            rend.enabled = false;
        }
        Debug.Log(this.gameObject.name + ": " +  i++);
    }

    private int i = 0;
    private int magicNumber;

    public Renderer rend;
}
