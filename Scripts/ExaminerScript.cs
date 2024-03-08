using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminerScript : MonoBehaviour
{
    [SerializeField]
    private ExaminerManagerScript examinerManager;
    [SerializeField]
    public float scaleOffset = 1f;
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
        print("Starting Examiner");
    }

    public void RequestUnexamine() 
    {
        examinerManager.UndoExaminer();
        print("Ending Examiner");
    }
}
