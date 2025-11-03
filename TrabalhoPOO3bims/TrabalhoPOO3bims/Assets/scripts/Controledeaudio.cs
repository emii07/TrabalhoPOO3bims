using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class  controle : MonoBehaviour
{
   public int volume;
   public int volumeSFX;
   public bool musica;
   public TMP_Text textomusica;


   public Slider volumeslider;
   public Slider volumesSFXSlider;
   public Toggle Togglemusica;


   void star()
   {
       musica = Togglemusica.isOn;
       volume = (int)volumeslider.value;
       volumeSFX = (int)volumesSFXSlider.value;
   }

   void update()
   {
       musica = Togglemusica.isOn;
       volume = (int)volumeslider.value;
       volumeSFX = (int)volumesSFXSlider.value;

       if (musica == true)
       {
           textomusica.text = "ligado";
           textomusica.color = Color.green;
       }
       else
       {
           textomusica.text = "Desligado";
           textomusica.color = Color.red;
       }
   }
   
}
