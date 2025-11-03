using UnityEngine;

public class personagem : MonoBehaviour
{ 
  
  
  [SerializeField]private int vidas;
  [SerializeField] private int energia;
  [SerializeField] private float velocidade;

  public void setvidas(int vidas)
  {
    this.vidas = vidas;
  }

  public int getvidas()
  {
    return this.vidas;
  }

  public void setenergia(int energia)
  {
    this.energia = energia;
  }

  public int getenergia()
  {
    return this.energia;
  }

  public void setenervelocidade(float velocidade)
  {
    this.velocidade = velocidade;
  }

  public float getvelocidade()
  {
    return this.velocidade;
  }
}
