using UnityEngine;

public class SquareBehaviour : MonoBehaviour
{
    bool isHeld;

    // Update is called once per frame
    void Update()
    {
        if (isHeld)
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                isHeld = false;
            }
            else
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hitInfo))
                {
                    transform.position = hitInfo.point;
                }
            }
        }
    }

    // Called whenever the mouse is over the collider
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isHeld = true;
        }
    }
}
