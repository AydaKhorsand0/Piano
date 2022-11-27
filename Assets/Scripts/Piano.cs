using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Piano : MonoBehaviour
{
    public AudioClip[] audioclip;
    private AudioSource audiosource;
    public Transform[] notesT;
    private void Start(){
        Notes.toneName +=PlaySound;
        audiosource= GetComponent<AudioSource>();
    }
    private void OnDestroy(){
        Notes.toneName -=PlaySound;
    }
    private void Update(){
        if(Input.GetMouseButtonUp(0)){
            for (int i=0;i<notesT.Length;i++){
                notesT[i].localScale=new Vector3(1,1,1);
            }
        }
    }
    public void PlaySound(string name){
            switch(name){
            case "C":
            audiosource.PlayOneShot(audioclip[0]);
            notesT[0].localScale=pos();
            break;
             case "Db":
            audiosource.PlayOneShot(audioclip[1]);
            notesT[1].localScale=pos();
            break;
             case "D":
            audiosource.PlayOneShot(audioclip[2]);
            notesT[2].localScale=pos();
            break;
             case "Eb":
            audiosource.PlayOneShot(audioclip[3]);
            notesT[3].localScale=pos();
            break;
             case "E":
            audiosource.PlayOneShot(audioclip[4]);
            notesT[4].localScale=pos();
            break;
             case "F":
            audiosource.PlayOneShot(audioclip[5]);
            notesT[5].localScale=pos();
            break;
             case "Gb":
            audiosource.PlayOneShot(audioclip[6]);
            notesT[6].localScale=pos();
            break;
             case "G":
            audiosource.PlayOneShot(audioclip[7]);
            notesT[7].localScale=pos();
            break;
             case "Ab":
            audiosource.PlayOneShot(audioclip[8]);
            notesT[8].localScale=pos();
            break;
             case "A":
            audiosource.PlayOneShot(audioclip[9]);
            notesT[9].localScale=pos();
            break;
             case "Bb":
            audiosource.PlayOneShot(audioclip[10]);
            notesT[10].localScale=pos();
            break;
             case "B":
            audiosource.PlayOneShot(audioclip[11]);
            notesT[11].localScale=pos();
            break;
             case "C1":
            audiosource.PlayOneShot(audioclip[12]);
            notesT[12].localScale=pos();
            break;
             case "Db1":
            audiosource.PlayOneShot(audioclip[13]);
            notesT[13].localScale=pos();
            break;
             case "D1":
            audiosource.PlayOneShot(audioclip[14]);
            notesT[14].localScale=pos();
            break;
             case "Eb1":
            audiosource.PlayOneShot(audioclip[15]);
            notesT[15].localScale=pos();
            break;
             case "E1":
            audiosource.PlayOneShot(audioclip[16]);
            notesT[16].localScale=pos();
            break;
             case "F1":
            audiosource.PlayOneShot(audioclip[17]);
            notesT[17].localScale=pos();
            break;
             case "Gb1":
            audiosource.PlayOneShot(audioclip[18]);
            notesT[18].localScale=pos();
            break;
             case "G1":
            audiosource.PlayOneShot(audioclip[19]);
            notesT[19].localScale=pos();
            break;
             case "Ab1":
            audiosource.PlayOneShot(audioclip[20]);
            notesT[20].localScale=pos();
            break;
             case "A1":
            audiosource.PlayOneShot(audioclip[21]);
            notesT[21].localScale=pos();
            break;
             case "Bb1":
            audiosource.PlayOneShot(audioclip[22]);
            notesT[22].localScale=pos();
            break;
             case "B1":
            audiosource.PlayOneShot(audioclip[23]);
            notesT[23].localScale=pos();
            break;
    }
    }
    private Vector3 pos(){
        return new Vector3(0.95f,0.95f,0.95f);
    }
}
