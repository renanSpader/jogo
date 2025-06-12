using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel; // Arrasta o painel aqui na Unity
    bool pausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuPanel.activeSelf)
            {
                FecharMenu();
            }
            else
            {
                AbrirMenu();
            }
        }
    }

    public void Play()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
        pausado = false;
        Debug.Log("Jogo rodando!");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
        pausado = true;
        Debug.Log("Jogo pausado!");
    }

    public void Sair()
    {
        Debug.Log("Fechou o jogo!");
        Application.Quit();
    }

    public void AbrirMenu()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0;
        pausado = true;
        Debug.Log("Menu Aberto");
    }

    public void FecharMenu()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
        pausado = false;
        Debug.Log("Menu Fechado");
    }
}