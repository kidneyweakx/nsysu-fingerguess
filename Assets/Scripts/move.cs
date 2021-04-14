using System.Collections;
using System.Collections.Generic;
using UnityEngine;
static public class variable
{   
    static public int health = 100;
    static public int ehealth = 100;
    static public int erps = 0;
    static public bool game = true;
}
public class move : MonoBehaviour
{
    Animator anim;
    public bool isEnemy = false;
    public AudioClip audio1;
    int Idle = Animator.StringToHash("Idle");
    int first = Animator.StringToHash("first");
    int thumbup = Animator.StringToHash("thumbup");
    int p = Animator.StringToHash("paper");
    int s = Animator.StringToHash("scissor");
    int st = Animator.StringToHash("stone");
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        AudioSource.PlayClipAtPoint(audio1, Vector3.zero);
        
    }
    // Update is called once per frame
    void Update()
    {
        if(!isEnemy){
            if(Input.GetKey(KeyCode.Q)) anim.SetTrigger(Idle);
            else if(Input.GetKeyDown(KeyCode.W)) anim.SetTrigger(first);
            else if(Input.GetKeyDown(KeyCode.E)) anim.SetTrigger(thumbup);
            else if(Input.GetKeyDown(KeyCode.A)) {
                variable.erps = Random.Range(0,3);
                anim.SetTrigger(p);
                if(variable.erps==2) variable.ehealth-=10;
                else if(variable.erps==1) variable.health-=10;
            }
            else if(Input.GetKeyDown(KeyCode.S)) {
                variable.erps = Random.Range(0,3);
                anim.SetTrigger(s);
                if(variable.erps==0) variable.ehealth-=10;
                else if(variable.erps==2) variable.health-=10;
                }
            else if(Input.GetKeyDown(KeyCode.D)) {
                variable.erps = Random.Range(0,3);
                anim.SetTrigger(st);
                if(variable.erps==1) variable.ehealth-=10;
                else if(variable.erps==0) variable.health-=10;
                }
        }else{
            switch(variable.erps){
                case 0:
                   anim.SetTrigger(p);
                   break;
                case 1: 
                    anim.SetTrigger(s);
                break;
                case 2: 
                    anim.SetTrigger(st);
                break;
                default:
                break;
            }
        }

            
    }
}
