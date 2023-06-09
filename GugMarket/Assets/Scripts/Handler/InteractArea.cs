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

    [SerializeField] public KitchenHandler kitchen;
    [SerializeField] public Transform cursor;
    [SerializeField] public float multiplier = .1f;
    [SerializeField] public Vector2 axisMultiplier = Vector2.one;

    void OnValidate()
    {
        area = new Bounds(transform.position, areaSize);
    }
    void Start()
    {
        OnValidate();
    }

    void Update()
    {
        var newPos = new Vector2(kitchen.currentDish.stat.axisSweetSalty, kitchen.currentDish.stat.axisSpicyFleshy);
        newPos *= axisMultiplier * multiplier;
        newPos = Vector2.ClampMagnitude(newPos, 7f);
        cursor.localPosition = Vector2.Lerp(cursor.localPosition, newPos, Time.deltaTime);
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
