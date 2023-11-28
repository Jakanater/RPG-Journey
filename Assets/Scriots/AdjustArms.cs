using UnityEngine;

public class VRCharacterArmAdjustment : MonoBehaviour
{
    public Transform leftController;
    public Transform rightController;
    public Transform headset;
    public Transform leftArmModel;
    public Transform rightArmModel;
    public Transform shoulderPivot; // Empty GameObject at the shoulders

    void Update()
    {
        // Get positions of controllers, headset, and shoulder pivot
        Vector3 leftControllerPos = leftController.position;
        Vector3 rightControllerPos = rightController.position;
        Vector3 headsetPos = headset.position;
        Vector3 shoulderPivotPos = shoulderPivot.position;

        // Calculate distance between the shoulder pivot and each controller
        float leftDistance = Vector3.Distance(shoulderPivotPos, leftControllerPos);
        float rightDistance = Vector3.Distance(shoulderPivotPos, rightControllerPos);

        // Use the average distance for adjustment
        float averageDistance = (leftDistance + rightDistance) / 2f;

        // Adjust virtual arm length based on the average distance
        AdjustArmLength(leftArmModel, averageDistance);
        AdjustArmLength(rightArmModel, averageDistance);
    }

    void AdjustArmLength(Transform armModel, float distance)
    {
        // Example: Scale arms based on the average distance
        float scaleFactor = Mathf.Clamp(distance / 2f, 0.5f, 2f); // Adjust scale limits as needed
        armModel.localScale = new Vector3(1f, scaleFactor, 1f);
    }
}