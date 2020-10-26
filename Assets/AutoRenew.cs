using UnityEngine;

public class AutoRenew : MonoBehaviour
{
    public RenewText playerGoldText;
    void Update() {
        playerGoldText.Renew(Player.INSTANCE.gold.GetGold().ToString()); // 매 프레임 플레이어의 골드를 갱신해준다.
    }
}
