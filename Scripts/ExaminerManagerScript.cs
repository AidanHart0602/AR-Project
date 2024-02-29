using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminerManagerScript : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;

    private ExaminerScript currentExaminedObject;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExecuteExaminer(ExaminerScript examiner)
    {
        currentExaminedObject = examiner;
        originalPosition = examiner.transform.position;
        originalRotation = examiner.transform.rotation;
        examiner.transform.position = targetTransform.position;
        examiner.transform.parent = targetTransform;
    }

    public void UndoExaminer()
    {
        currentExaminedObject.transform.position = originalPosition;
        currentExaminedObject.transform.rotation = originalRotation;
        currentExaminedObject.transform.parent = null;
    }
}
