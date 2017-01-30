using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
 
public class MyS : NetworkBehaviour {
    [SerializeField] Text m_healthText;
 
    [SyncVar(hook = "OnHealthChanged")]
    public int m_health;
	public Text heal;

	void Start() {
		heal = GameObject.Find ("heal").GetComponent<Text> ();
	}

    public override void OnStartLocalPlayer ()
    {
		

        GetComponent<MeshRenderer>().material.color = Color.red;
        CmdSetHealth(100);
    }
 
    public override void OnStartClient ()
    {
        OnHealthChanged(m_health);
    }
 
    // Update is called once per frame
    void Update () {
		if (isLocalPlayer) {
			heal.text = "Health" + m_health;
		}
        if(isLocalPlayer)
        {

            if(Input.GetKeyDown(KeyCode.Space))
            {
                CmdSetHealth(m_health - 10);
            }
        }
    }
 
    [Command]
    void CmdSetHealth(int health)
    {
        m_health = health;
    }
 
    void OnHealthChanged(int newHealth)
    {
        m_health = newHealth;
        m_healthText.text = "Health: " + m_health.ToString();
    }


}