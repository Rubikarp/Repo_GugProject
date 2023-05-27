using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class InteractArea : SingletonMonoBehaviour<InteractArea>
{
    [ReadOnly] public Bounds area = new Bounds(Vector2.zero, Vector2.one);
    [SerializeField] public Vector2 areaSize =Vector2.one;

    void OnValidate()
    {
        area = new Bounds(transform.position, areaSize);
    }

    void Update()
    {
        
    }

    public Vector3 GetMousePos()
    {
        //Reset HitPoint
        var ray = Utilities_UI.MouseScreenRay();
        var plane = new Plane(Vector3.back, transform.position);

        Vector3 hitPoint = Vector3.zero;
        float hitDist = 0f;

        //Raycast
        plane.Raycast(ray, out hitDist);
        hitPoint = ray.GetPoint(hitDist);

        if (!area.Contains(hitPoint))
        {
            hitPoint = area.ClosestPoint(hitPoint);
        }

        return hitPoint;
    }

    private void OnDrawGizmos()
    {
#if UNITY_EDITOR
        using (new Handles.DrawingScope(Color.red))
        {
            Extension_Handles.DrawWireSquare(area.center, area.size);
        }
#endif
    }
}
