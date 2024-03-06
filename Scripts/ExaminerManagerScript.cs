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
    private Vector3 OriginalScale;
    private float rotationSpeed = 1;
    private bool examinationActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            print("Touch Detected");

            if (examinationActive == true)
            {
                Touch touch = Input.GetTouch(0);
                
                if (touch.phase == TouchPhase.Moved)
                {
                    currentExaminedObject.transform.Rotate(touch.deltaPosition.x * rotationSpeed, touch.deltaPosition.y * rotationSpeed, 0);
                }
            }
        }
    }

    public void ExecuteExaminer(ExaminerScript examiner)
    {
        currentExaminedObject = examiner;
        originalPosition = examiner.transform.position;
        originalRotation = examiner.transform.rotation;
        OriginalScale = examiner.transform.localScale;

        Vector3 otherScaleOffset = OriginalScale * examiner.scaleOffset;

        examiner.transform.position = targetTransform.position;
        examiner.transform.parent = targetTransform;
        examinationActive = true;
    }

    public void UndoExaminer()
    {
        currentExaminedObject.transform.position = originalPosition;
        currentExaminedObject.transform.rotation = originalRotation;

        currentExaminedObject.transform.localScale = OriginalScale;

        currentExaminedObject.transform.parent = null;
        currentExaminedObject = null;
        examinationActive = false;
    }
}
