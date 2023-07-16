using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Futbplmanaguer : MonoBehaviour
{
    public Transform[] pelotas;
    public Vector3[] posicion;
    public Collider2D[] colisionPelotas;

    public Text[] balonesRespueta;
    public Text[] preguntaSuma;
    public Text[] acierto;
    public Text[] error;
    int lugaraleatorioRespuestabalones;
    int num1, num2, num3, num4;
    int titulo1, titulo2, titulo3, titulo4;
    int sumatitulos;

    // Start is called before the first frame update
    void Start()
    {
        lugaraleatorioRespuestabalones = Random.Range(0, balonesRespueta.Length);
        titulo1 = Random.Range(1, 10);
        titulo2 = Random.Range(1, 10);
        titulo3 = Random.Range(1, 10);
        titulo4 = Random.Range(1, 10);
        sumatitulos = titulo1 + titulo2 + titulo3 + titulo4;

      num1 = Random.Range(4, 37);
      num2 = Random.Range(4, 37);
      num3 = Random.Range(4, 37);
      num4 = Random.Range(4, 37);

      preguntaSuma[0].text = titulo1.ToString();
      preguntaSuma[1].text = titulo2.ToString();
      preguntaSuma[2].text = titulo3.ToString();
      preguntaSuma[3].text = titulo4.ToString();
       
      

      balonesRespueta[0].text = num1.ToString();
      balonesRespueta[1].text = num2.ToString();
      balonesRespueta[2].text = num3.ToString();
      balonesRespueta[3].text = num4.ToString();

        /* The code block you provided is a for loop that iterates through the `balonesRespueta` array. */
        for (int i = 0; i <= balonesRespueta.Length-1; i ++)
        {
            if (i == lugaraleatorioRespuestabalones)
            {
                balonesRespueta[i].text =sumatitulos.ToString();
            }
        }
        activadorColiderPelota(true);
        posicion[0] = new Vector3(pelotas[0].position.x, pelotas[0].position.y, pelotas[0].position.z);
        posicion[1] = new Vector3(pelotas[1].position.x, pelotas[1].position.y, pelotas[1].position.z);
        posicion[2] = new Vector3(pelotas[2].position.x, pelotas[2].position.y, pelotas[2].position.z);
        posicion[3] = new Vector3(pelotas[3].position.x, pelotas[3].position.y, pelotas[3].position.z);
    }
    void activadorColiderPelota (bool activa) {
        foreach (Collider2D a in colisionPelotas)
        {
            a.enabled = activa;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Pelota.dasClick == true){
            activadorColiderPelota(false);
        }
        if(Pelota.ahllegado == true)
        {
            for (int i = 0; i <= pelotas.Length - 1; i++)
            {
                activadorColiderPelota(true);
                pelotas[i].position = posicion[i];
                pelotas[i].localScale = Vector3.one / 2;
            }
            Pelota.ahllegado = false;
            Pelota.dasClick = false;
        }  
       
    }
}
