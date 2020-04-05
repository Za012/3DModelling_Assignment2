using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Hotspot currentlyHovered;
    // Update is called once per frame
    void Update()
    {

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
