using UnityEditor.Build.Player;
using UnityEngine;

public class MainGameUi : MonoBehaviour
{
    #region Main Menu Goer.
    [SerializeField] KeyCode escKey;
    PlayerUtils pU;

    #endregion


    private void Update()
    {
        if (Input.GetKeyDown(escKey))
        {
            Time.timeScale = 1f;
            pU.Enableing();
        }
    }




}
