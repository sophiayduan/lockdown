using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform aimSphere;
    public LayerMask layerMask;
    public int maxDistance;
   
    void Update()
    {
        Vector2 screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance,layerMask))
        {
            aimSphere.position = Vector3.Lerp(aimSphere.position, hit.point, 10f * Time.deltaTime);
        }
        else 
        {
            Vector3 destination = ray.origin + ray.direction * 10;  
            aimSphere.position = Vector3.Lerp(aimSphere.position, destination, 10f * Time.deltaTime);

        }

    }


}
