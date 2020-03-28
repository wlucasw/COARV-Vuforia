using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private bool drill = false;
    private bool wave = false;
    private bool idle = true;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Toggle Drilling");
            wave = false;
            m_Animator.SetBool("IsWaving", wave);
            drill = !drill;
            m_Animator.SetBool("IsDrilling", drill);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Waving");
            drill = false;
            m_Animator.SetBool("IsDrilling", drill);
            wave = !wave;
            m_Animator.SetBool("IsWaving", wave);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Resetting");
            drill = false;
            wave = false;
            m_Animator.SetBool("IsDrilling", drill);
            m_Animator.SetBool("IsWaving", wave);
        }
    }
}
