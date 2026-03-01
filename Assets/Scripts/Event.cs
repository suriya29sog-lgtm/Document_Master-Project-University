using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GameDev3.Project
{
    public class Event : MonoBehaviour
    {
        [SerializeField] protected UnityEvent Clicked = new();

        public void OnClicked()
        {
            Clicked.Invoke();
        }
    }
}