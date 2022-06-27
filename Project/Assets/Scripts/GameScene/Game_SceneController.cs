using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_SceneController : MonoBehaviour
{
    public static Game_SceneController instance;

    [Header("Grid settings :")]
    [SerializeField] [Range(3, 5)] private int width = 5;
    [SerializeField] [Range(3, 7)] private int heigth = 7;

    [Header("Item settings :")]
    public bool changeColor = true;
    public Sprite blueItemImage;
    public Sprite redItemImage;
    public Sprite yellowItemImage;

    BurgerMenu burgerMenu;
    GameGrid grid;

    private void Awake()
    {
        Set_AsSingletone();
        Check_ItemImages();

        burgerMenu = new BurgerMenu();
        grid = new GameGrid(width, heigth);
    }

    private void Check_ItemImages()
    {
        if(blueItemImage == null)
            blueItemImage = Resources.Load<Sprite>("Items/unity_1");

        if (redItemImage == null)
            redItemImage = Resources.Load<Sprite>("Items/unity_1");

        if (yellowItemImage == null)
            yellowItemImage = Resources.Load<Sprite>("Items/unity_1");
    }

    private void Set_AsSingletone()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
}