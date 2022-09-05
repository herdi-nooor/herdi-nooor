using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public static class Helper
{

    //// Camera reference
    private static Camera _camera;

    public static Camera Camera{
        get {
            if (_camera == null) _camera = Camera.main;
            return _camera;
        }
    }

    //// non-allocating WaitForSeconds

    private static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds GetWait(float time){
        if (WaitDictionary.tryGetValue(time, out var wait)) return wait;
        
        WaitDictionary[time] = new WaitForSeconds(time);
        return WaitDictionary[time];
    } 
    
    //// check is pointer over UI

    private static PointerEventData _eventDataCurentPosition;
    private static List<RaycastResult> _results;

    public static bool IsOverUi(){
        _eventDataCurentPosition = new PointerEventData(EventSystems.current) { position = Input.mousePosition};
        _results = new List<RaycastResult>();
        EventSystems.current.RaycastAll(_eventDataCurentPosition, _results);
        return _results.Count > 0;
    }

    //// find world point of canvas element

    public static Vector2 GetWolrdPositionOfCanvasElement(RectTransform element){
        RectTransformUtility.ScreenPointToWorldPointInRectangle(element, element.position, Camera, out var results);
        return results;
    }

    //// delete all childs of object parent

    public static void DeleteChildren(this Transform t){
        foreach (Transform child in t) Object.Destroy(child.gameObject);
    }
}
