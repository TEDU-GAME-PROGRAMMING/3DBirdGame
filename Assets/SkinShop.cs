using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinShop: MonoBehaviour
{
  [SerializeField] private SkinManager skinManager;
  [SerializeField] private int skinIndex;
  [SerializeField] private Button buyButton;
  [SerializeField] private TextMeshProUGUI costText;
  private Skin skin;

  void Start()
  {
    skin = skinManager.skins[skinIndex];
    if(skinIndex==0){
      skinManager.Unlock(skinIndex);
    }

    GetComponent<Image>().color = skin.spritematerial.color;

    if (skinManager.IsUnlocked(skinIndex))
    {
      buyButton.gameObject.SetActive(false);
    }
    else
    {
      buyButton.gameObject.SetActive(true);
      costText.text = skin.cost.ToString();
    }
  }

  public void OnSkinPressed()
  {
    if (skinManager.IsUnlocked(skinIndex))
    {
      skinManager.SelectSkin(skinIndex);
    }
  }

  public void OnBuyButtonPressed()
  {
    int coins = PlayerPrefs.GetInt("coin", 0);

    // Unlock the skin
    if (coins >= skin.cost && !skinManager.IsUnlocked(skinIndex))
    {
      PlayerPrefs.SetInt("coin", coins - skin.cost);
      skinManager.Unlock(skinIndex);
      buyButton.gameObject.SetActive(false);
      skinManager.SelectSkin(skinIndex);
    }
    else
    {
      Debug.Log("Not enough coins :(");
    }
  }
}