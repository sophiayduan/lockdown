using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Camera cam;
    public Transform aimSphere;
    public LayerMask layerMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
        Ray ray = cam.ScreenPointToRay(screenCenter);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerMask))
        {
            aimSphere.position = Vector3.Lerp(aimSphere.position, hit.point, 5f * Time.deltaTime );
        }



    }
}
