using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImplementHelper : MonoBehaviour
{   
    [SerializeField] private Text _text;
    [SerializeField] private RectTransform _followTarget;


    // allocate by unuty in ienumerator
    IEnumerator Bad(){
        for (var i = 0; i < 100; i++){
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void Update() {
    /// test overUI
        _text.text = Helper.IsOverUi() ? "over UI" : "free pointing";

        // transform dari object yang di gerakan mengikuti _followTarget
        transform.position = Helper.GetWolrdPositionOfCanvasElement(_followTarget);
    }




}
