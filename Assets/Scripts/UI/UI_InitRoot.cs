using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Munchkin
{
    public class UI_InitRoot : MonoBehaviour
    {
        public static UI_InitRoot Instance;
        void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            //Initalize_UI
            UIManager.Instance = new UIManager();
            UIManager.Instance.Get_UI<UI_PlayerPanel>();
            UIManager.Instance.Get_UI<UI_PlayerPanel>();
        }

    }
}