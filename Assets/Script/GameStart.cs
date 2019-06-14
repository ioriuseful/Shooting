using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update

        public void OnRetry()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
