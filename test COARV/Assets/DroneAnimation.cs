using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private bool scan = false;
    private bool collect = false;
    private bool facingObject = false;

    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        facingObject = m_Animator.GetBool("IsFacingObject");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Toggle Facing Object");
            facingObject = !facingObject;
            m_Animator.SetBool("IsFacingObject", facingObject);
        }

        if ((Input.GetKeyDown(KeyCode.S)) && facingObject)
        {
            Debug.Log("Toggle Scanning");
            scan = !scan;
            m_Animator.SetBool("IsScanning", scan);
        }

        if (Input.GetKeyDown(KeyCode.C)) // && rock est en dessous
        {
            Debug.Log("Toggle Collecting Rock");
            collect = !collect;
            m_Animator.SetBool("CollectRock", collect);
        }
    }
}
