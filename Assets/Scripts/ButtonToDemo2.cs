using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToDemo2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (choose.record < 1)
        {
            this.GetComponent<Button>().interactable = false;
        }
        else
        {
            Debug.Log("aaa");
            this.GetComponent<Button>().interactable = true;
        }
    }
}
