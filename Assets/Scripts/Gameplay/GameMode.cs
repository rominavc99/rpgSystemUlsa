using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    List<Transform> party;
    Queue<Transform> partyQueue;

    
    IEnumerator Start()
    {

        while(true)
        {
            if(Gamemanager.Instance)
            {
                partyQueue = new Queue<Transform>(party);
                
                Gamemanager.Instance.CurrentGameMode = this;
                break;
            }
            yield return null;
        }
    }

   
    void Update()
    {
        
    }

    public Transform GetPartyLeader => partyQueue.Peek();

    public bool CompareToLeader(Transform leader) => GetPartyLeader.Equals(leader);

    public void ChangeLeader(Transform hero)
    {
        if(CompareToLeader(hero))
        {
            partyQueue.Enqueue(partyQueue.Dequeue());
        }
    }
}
