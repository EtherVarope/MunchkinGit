using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[SelectionBase]
public abstract class BaseUI : MonoBehaviour {

    // Use this for override
    public abstract void Install_UI();
    public abstract void Uninstall_UI();
    
   
}
