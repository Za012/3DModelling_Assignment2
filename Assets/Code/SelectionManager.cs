using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{
    private Hotspot currentlyHovered;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("PanoSceneLow", LoadSceneMode.Single);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("PanoSceneMid", LoadSceneMode.Single);
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit)){
            var selection = hit.transform;
            var hotSpot = selection.GetComponent<Hotspot>();
            if(hotSpot != null)
            {
                hotSpot.Hovered();
                currentlyHovered = hotSpot;
            }
        }
        else
        {
            if (currentlyHovered != null)
            {
                currentlyHovered.DeHovered();
            }
        }
    }
}
