using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Trigger : MonoBehaviour
{
    public UnityEvent OnExecute;
    public UnityEvent OffExecute;
    private bool _isExecuted;
    public void Execute()
    {
        if(_isExecuted == false)
        {
            OnExecute.Invoke();
        }
        else
        {
            OffExecute.Invoke();
        }
        _isExecuted = !_isExecuted;
    }
}
