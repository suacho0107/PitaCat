using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToClearDialog : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    public void ChangeScene()
    {
        // ������ �� �̸����� ��ȯ
        SceneManager.LoadScene(sceneToLoad);
    }

    // �ƴ� �̰� �۵� �Ǵ°�? �� ��ư���� �Ϸ��� ��
}