using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ShopController : MonoBehaviour
{
  [SerializeField] private Image selectedSkin;
  [SerializeField] private TextMeshProUGUI coinsText;
  [SerializeField] private SkinManager skinManager;

  void Update()
  {
    coinsText.text = "Coins: " + PlayerPrefs.GetInt("coin");
    selectedSkin.color = skinManager.GetSelectedSkin().spritematerial.color;
  }

  public void LoadMenu() => SceneManager.LoadScene("MainMenuScene");
}