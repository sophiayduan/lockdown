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

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity,layerMask))
        {
            aimSphere.position = Vector3.Lerp(aimSphere.position, hit.point, maxDistance * Time.deltaTime );
        }
        else 
        {
            Vector3 destination = ray.origin + ray.direction *maxDistance;  
            aimSphere.position = Vector3.Lerp(aimSphere.position, destination, maxDistance* Time.deltaTime);

        }

    }

}
