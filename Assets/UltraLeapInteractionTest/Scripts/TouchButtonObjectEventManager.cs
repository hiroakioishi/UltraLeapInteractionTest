using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchButtonObjectEventManager : MonoBehaviour
{
    public List<string> colliderNameList = new List<string>();

    [Tooltip("インタラクションオブジェクトに接触したときに発行するイベントを登録する")]
    public UnityEvent touchEvent;

    int _count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (colliderNameList != null && colliderNameList.Count > 0)
        {
            for (var i = 0; i < colliderNameList.Count; i++)
            {
                if (other.gameObject.name == colliderNameList[i])
                {
                    GetComponent<Renderer>().sharedMaterial.color = Color.HSVToRGB((_count*0.44444f)%1.0f, 1.0f, 1.0f);

                    if (touchEvent != null)
                    {
                        touchEvent.Invoke();
                    }

                    _count++;
                }
            }
        }
    }
}
