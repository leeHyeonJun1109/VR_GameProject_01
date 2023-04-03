using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player
{
    private int hp = 100;
    private int Power = 50;

    public void Attack()
    {
        Debug.Log(this.Power + "데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }

    public int GetHp()
    {
        return this.hp;
    }
}
public class Test_008 : MonoBehaviour
{
    
        Player player_01 = new Player();
        Player player_02 = new Player();
        public Text player01Hp;
        public Text player02Hp;
    // Start is called before the first frame update
    void Start()
    {
        player_01.Attack();
        player_01.Damage(30);
    }


    // Update is called once per frame
    void Update()
    {
        player01Hp.text = "Player 01 Hp : " + player_01. GetHp(). ToString();
        player02Hp.text = "Player 02 Hp : " + player_02. GetHp(). ToString();

        if(Input.GetMouseButton(0))
        {
            player_01.Damage(1);
        }

        if (Input.GetMouseButton(1))
        {
            player_02.Damage(1);
        }
    }
}
