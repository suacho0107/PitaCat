using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToClearDialog : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    public void ChangeScene()
    {
        // ������ �� �̸����� ��ȯ
        SceneManager.LoadScene(sceneToLoad);
    }
}
