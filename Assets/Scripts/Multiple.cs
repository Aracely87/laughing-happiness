using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiple : MonoBehaviour
{
   
    public Button[] botonesrespuesta;
   public GameObject Pantllafinal; 

    public Text pregunta;
    string PreguntaFinal;
    public Text[] respuestas;
    public Text cronometrotexto;
    public Text Puntaje;

    int producto;
    int aleatoriorespuesta;
    int numero1;
    int numero2;
    int a;
    bool b;
    public int Maximopuntaje;

    //metodos
    public int tiempocronometro;
    private float contador;
    // Start is called before the first frame update
    void Start()
    {
        
        b = true;
        int a = 0; foreach (Button item in botonesrespuesta)
        {
            item.interactable = true;
        }
        Pantllafinal.SetActive(false);
        
        Puntaje.text = a.ToString();
        contador = tiempocronometro;
        cronometrotexto.text = contador.ToString();
        inicidador();
    }
     void inicidador()
    { 
        numero1 = Random.Range(2, 9);
        numero2 = Random.Range(2, 9);
        aleatoriorespuesta = Random.Range(0, respuestas.Length);
        producto = numero1 + numero2;
        PreguntaFinal = numero1.ToString() + "+" + numero2.ToString();
        pregunta.text = PreguntaFinal;
        

        for (int i = 0; i <= respuestas.Length - 1; i++)
        {
            if (i == aleatoriorespuesta)
            {
                respuestas[i].text = producto.ToString();
            }
            else if (i != aleatoriorespuesta)
            {
                respuestas[i].text = Random.Range(2, 20).ToString();
            }


        }
    }

    public void daleClick1()
    {
        if (respuestas[0].text == producto.ToString()){
            a = a + 1;
            Puntaje.text = a.ToString();
        }
        contador = tiempocronometro;
        inicidador();
    }

    /// <summary>
    /// The function "daleClick2" checks if the second answer matches the product, increments the score
    /// if it does, and resets the timer.
    /// </summary>
    public void daleClick2()
    {
        if (respuestas[1].text == producto.ToString()){
            a = a + 1;
            Puntaje.text = a.ToString();
        }
        contador = tiempocronometro;
        inicidador();
    }

    public void daleClick3()
    {
        if (respuestas[2].text == producto.ToString())
        {
            a = a + 1;
            Puntaje.text = a.ToString();
        }
        contador = tiempocronometro;
        inicidador();
    }


    // Update is called once per frame
    void Update()
    {
        if (Puntaje.text == Maximopuntaje.ToString() && b == true) {
            Pantllafinal.SetActive(true);
           
            foreach (Button item in botonesrespuesta)
            {
                item.interactable = false;
            }
            b = false;
        }
        if (b == true)
        {
            contador = contador - Time.deltaTime;
            cronometrotexto.text = contador.ToString("0");
            if (contador <= 0)
            {
                inicidador();
                contador = tiempocronometro;
                cronometrotexto.text = contador.ToString();
            }
        }
        
    }
}
