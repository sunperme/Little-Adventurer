using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
#if UNITY_EDITOR
using static UnityEditor.Searcher.SearcherWindow.Alignment;
#endif


public class PlayerInput : MonoBehaviour
{

    public float Horizo​​ntalInput;
    public float VerticalInput;
    public bool MouseButtonDown;
    public bool SpaceKeyDown;
    

    // Update is called once per frame
    void Update()
    {
        if (!MouseButtonDown && Time.timeScale != 0)
        {
            MouseButtonDown = Input.GetMouseButtonDown(0);
        }

        if (!SpaceKeyDown && Time.timeScale != 0)
        {
            SpaceKeyDown = Input.GetKeyDown(KeyCode.Space);
        }

        Horizo​​ntalInput = Input.GetAxisRaw("Horizontal"); 
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void OnDisable()
    {
        ClearCache();
    }

    public void ClearCache()
    {
        MouseButtonDown = false;
        SpaceKeyDown = false;
        Horizo​​ntalInput = 0;
        VerticalInput = 0;
    }
}
