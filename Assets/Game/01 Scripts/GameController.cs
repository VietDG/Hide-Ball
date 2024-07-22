using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : SingletonMonoBehaviour<GameController>
{
    public List<ItemColection> itemList = new List<ItemColection>();

    public Dictionary<ItemColection, int> itemDicts = new Dictionary<ItemColection, int>();

    [SerializeField] GameObject _spawnObj;

    [SerializeField] Ostable[] _ostables;

    [SerializeField] StateGameController _stateController;

    public ItemColection Player;

    public bool isWin;

    public bool isLose;

    private void Awake()
    {
        LoadLevel();
    }

    void LoadLevel()
    {
        Debug.LogError("Level/Level" + $"{PlayerData.userData.HighestLevel + 1}");
        GameObject myPrefab = Resources.Load<GameObject>("Level/Level" + $"{PlayerData.userData.HighestLevel + 1}");

        if (myPrefab != null)
        {
            Instantiate(myPrefab, Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Không thể tải GameObject từ thư mục Resources.");
        }
    }

    void Start()
    {
        foreach (ItemColection item in FindObjectsOfType<ItemColection>())
        {
            itemList.Add(item);
            itemDicts.Add(item, 0);
            if (item.Type.Equals(TypeItem.Ball))
            {
                Player = item;
            }
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void OnClick(ItemColection colection)
    {
        if (_stateController.stateGame.Equals(StateGame.Checking) || _stateController.stateGame.Equals(StateGame.Win)) return;
        colection.Movement();
        itemList.Remove(colection);

        if (itemList.Count == 0)
        {
            _stateController.Checking();
            StartCoroutine(WaitSusuwatariMove());
        }
    }

    IEnumerator WaitSusuwatariMove()
    {
        yield return new WaitForSeconds(2f);
        Debug.LogError("fly");
        OstableMove();
        yield return new WaitForSeconds(4f);
        StopOstable();
        if (isLose == false)
        {
            _stateController.Win();
            Debug.LogError("Win");
            PlayerData.userData.UpdateHigestLevel();
            SceneManager.LoadScene(Const.SCENE_GAME);
        }
    }

    public void OstableMove()
    {
        for (int i = 0; i < _ostables.Length; i++)
        {
            _ostables[i].Movement();
        }
    }

    public void StopOstable()
    {
        for (int i = 0; i < _ostables.Length; i++)
        {
            _ostables[i].Stop();
        }
    }
}
