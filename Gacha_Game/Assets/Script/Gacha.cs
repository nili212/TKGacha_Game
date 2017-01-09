using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour {

    public Entity_RarityData rarityData;
    public Entity_GachaData[] charaData;

    public GameObject[] performancesPrefab;
    private GameObject performance;

    public GameObject gachaButtonPrefab;
    private GameObject gachaButton;

    public GameObject cardPrefab;
    private GameObject card;

    public TextMesh textPrefab;
    private TextMesh text;

    public GameObject rarityStarPrefab;
    private GameObject rarityStar;

    private bool performancestart = false;

    private int rarity;
    private int chara;

    // Use this for initialization
    void Start ()
    {
        gachaButton = Instantiate(gachaButtonPrefab);
        performancestart = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !performancestart)
        {
            rarity = RarityCheck();

            chara = CharaCheck(rarity);

            Destroy(gachaButton);

            if(!performancestart)
                GachaPerformance(rarity);

            Debug.Log("レアリティ : " + charaData[rarity].param[chara].Rarity);
            Debug.Log("キャラネーム : " + charaData[rarity].param[chara].Name);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }

        if (performancestart && performance == null && card == null)
        {
            cardPrefab.GetComponent<CardSprite>().spriteID = charaData[rarity].param[chara].IdData;
            card = Instantiate(cardPrefab);

            textPrefab.text  = charaData[rarity].param[chara].Name.ToString();
            text = Instantiate(textPrefab);

            rarityStarPrefab.GetComponent<RarityStar>().rarityStarID = rarity;
            rarityStar = Instantiate(rarityStarPrefab);

        }
    }

    //レアリティの判別
    int RarityCheck()
    {
        //レアリティ数設定(レアリティデータの配列幅を取得)
        int[] rarityWeight = new int[rarityData.param.Count];

        //レアリティの重み設定(レアリティデータから重みの値を取得)
        for (int i = 0; i < rarityData.param.Count; i++)
        {
            rarityWeight[i] = rarityData.param[i].RarityHeavy;
        }

        //判別開始
        var index = MyUtil.GetRandomIndex(rarityWeight);

        return index;
    }

    int CharaCheck(int rarity)
    {
        int[] charaWeight = new int[charaData[rarity].param.Count];

        for(int i = 0; i < charaData[rarity].param.Count; i++)
        {
            charaWeight[i] = charaData[rarity].param[i].Heavy;
        }

        int index = MyUtil.GetRandomIndex(charaWeight);

        return index;
    }

    void GachaPerformance(int rarity)
    {
        performance = Instantiate(performancesPrefab[rarity]);
        performancestart = true;
    }
}
