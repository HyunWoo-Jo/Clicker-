﻿public class Player : SingletonObject<Player> // SingletonObject를 상속
{
    public Gold gold = new Gold();
    public Gold increaseGold; // 클릭시 증가 골드

    public void ClickAct() { // 클릭시 골드를 추가한다
        gold.SetGold(increaseGold.GetGold() + gold.GetGold());
    }

    public void Start() {
        increaseGold.SetGold(2); // Text Code inceadse Gold 를 임시로 증가시킴
    }
}   