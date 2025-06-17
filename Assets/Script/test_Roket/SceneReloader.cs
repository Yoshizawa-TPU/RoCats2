using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // ���݂̃A�N�e�B�u�ȃV�[�����擾
            Scene currentScene = SceneManager.GetActiveScene();
            // �V�[�����ēǂݍ���
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
