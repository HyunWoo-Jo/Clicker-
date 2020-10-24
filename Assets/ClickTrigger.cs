using UnityEngine;

public class ClickTrigger : MonoBehaviour
{
    public RenewText textGold;
    
    public void EnterTrigger() {
        Player.INSTANCE.ClickAct(); // Player ClickAct() 호출한다.
        textGold.Renew(Player.INSTANCE.gold.GetGold().ToString()); // gold값을 Renew 시킨다.
    }
}
