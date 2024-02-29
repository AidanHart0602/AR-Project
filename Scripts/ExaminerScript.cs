using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminerScript : MonoBehaviour
{
    [SerializeField]
    private ExaminerManagerScript examinerManager;

    void Start()
    {
        examinerManager = FindObjectOfType<ExaminerManagerScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallExaminer() 
    {
        examinerManager.ExecuteExaminer(this);
    }
}
