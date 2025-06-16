using UnityEngine;

public class SphereRocketController : MonoBehaviour
{
    public GameObject leftSphereObject;
    public GameObject rightSphereObject;
    public float thrustForce = 20f;

    private Rigidbody leftRb;
    private Rigidbody rightRb;

    void Start()
    {
        leftRb = leftSphereObject.GetComponent<Rigidbody>();
        rightRb = rightSphereObject.GetComponent<Rigidbody>();

        if (leftRb == null || rightRb == null)
        {
            Debug.LogError("�X�t�B�A�� Rigidbody ���A�^�b�`����Ă��܂���I");
        }
    }

    void FixedUpdate()
    {
        // ���N���b�N�����Ă���ԁA���X�t�B�A�ɏ�����̗͂�^��������
        if (Input.GetMouseButton(0) && leftRb != null)
        {
            leftRb.AddForce(leftSphereObject.transform.up * thrustForce, ForceMode.Force);
        }

        // �E�N���b�N�����Ă���ԁA�E�X�t�B�A�ɏ�����̗͂�^��������
        if (Input.GetMouseButton(1) && rightRb != null)
        {
            rightRb.AddForce(rightSphereObject.transform.up * thrustForce, ForceMode.Force);
        }
    }
}
