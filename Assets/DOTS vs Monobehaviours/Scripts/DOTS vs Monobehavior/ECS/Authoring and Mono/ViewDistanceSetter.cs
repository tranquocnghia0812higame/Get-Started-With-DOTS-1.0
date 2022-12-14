using Unity.Entities;
using UnityEngine;

public class ViewDistanceSetter : MonoBehaviour
{
    [SerializeField] Camera cam;
    // Start is called before the first frame update
    public void SetDistanceFromOrigin(float distance)
    {
        Vector3 viewDirection = cam.transform.position.normalized;
        cam.transform.position = viewDirection * distance;
    }
}
