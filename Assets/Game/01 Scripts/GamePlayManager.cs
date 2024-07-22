using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    [Header("---------------------REFERENCE--------------------")]
    [SerializeField] GameController _controller;
    public GameController controller => _controller;
    [Header("---------------------Tool-------------------------")]
    [SerializeField] int _level;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PlayerData.userData.HighestLevel = _level == 0 ? 0 : _level - 1;

            SceneManager.LoadScene(Const.SCENE_GAME);
        }
    }
}
