using UnityEngine;

public class Pickup : MonoBehaviour
{
    // public Camera cam;
    public Transform aimSphere;
    public LayerMask layerMask;
   
    void Update()
    {
        Vector2 screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            aimSphere.position = Vector3.Lerp(aimSphere.position, hit.point, 25f * Time.deltaTime );
        }
        else 
        {
            Vector3 destination = ray.origin + ray.direction * 25;  
            aimSphere.position = Vector3.MoveTowards(aimSphere.position, destination, 25f * Time.deltaTime);
        }

    }
}
