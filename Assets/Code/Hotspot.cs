using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotspot : MonoBehaviour
{
    // Start is called before the first frame update
    internal void Hovered()
    {
        
        transform.localScale = new Vector3(5, 5, 5);
        transform.Find("name").gameObject.SetActive(true);
    }
    internal void DeHovered()
    {
        transform.localScale = new Vector3(3, 3, 3);
        transform.Find("name").gameObject.SetActive(false);
    }
}
