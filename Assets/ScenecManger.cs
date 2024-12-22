using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenecManger : MonoBehaviour
{
    public void SwiychScene(int num)
    {
        SceneManager.LoadScene(num);
    }
}