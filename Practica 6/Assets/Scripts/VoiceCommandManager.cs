using System.Collections.Generic;
using UnityEngine;
using IBM.Watsson.Examples;

public class VoiceCommandManager : MonoBehaviour
{
    [SerializeField] private GameObject pokemon1;
    [SerializeField] private GameObject pokemon2;
    [SerializeField] private GameObject pokemon3;
    [SerializeField] private GameObject pokemon4;
    public List<string> commands = new List<string>();
    public ExampleStreaming exampleStreaming;
    
    void Start()
    {
        if (exampleStreaming != null )
        {
            exampleStreaming.onCommandReceived += ExecuteCommand;
        }
        pokemon1.SetActive(false);
        pokemon2.SetActive(false);
        pokemon3.SetActive(false);
        pokemon4.SetActive(false);
    }

    public void ExecuteCommand(string transcriptCommand)
    {
        string[] words = transcriptCommand.Split(' ');
        for(int i=0; i < words.Length; i++)
        {
            if(commands.Contains(words[i].ToLower()))
            {
                Debug.Log("Ejecutando comando " + words[i]);
                ChoosePokemon(words[i+1]);
            }
        }
    }

    private void ChoosePokemon(string election)
    {
        switch (election)
        {
            case "uno":
            if (!pokemon1.activeSelf)
            {
                pokemon1.SetActive(true);
                if (pokemon2.activeSelf || pokemon3.activeSelf || pokemon4.activeSelf)
                {
                    pokemon2.SetActive(false);
                    pokemon3.SetActive(false);
                    pokemon4.SetActive(false);
                }
            }
            break;

            case "2":
            if (!pokemon2.activeSelf)
            {
                pokemon2.SetActive(true);
                if (pokemon1.activeSelf || pokemon3.activeSelf || pokemon4.activeSelf)
                {
                    pokemon1.SetActive(false);
                    pokemon3.SetActive(false);
                    pokemon4.SetActive(false);
                }
            }
            break;

            case "3":
            if (!pokemon3.activeSelf)
            {
                pokemon3.SetActive(true);
                if (pokemon1.activeSelf || pokemon2.activeSelf || pokemon4.activeSelf)
                {
                    pokemon1.SetActive(false);
                    pokemon2.SetActive(false);
                    pokemon4.SetActive(false);
                }
            }
            break;

            case "4":
            if (!pokemon4.activeSelf)
            {
                pokemon4.SetActive(true);
                if (pokemon1.activeSelf || pokemon2.activeSelf || pokemon3.activeSelf)
                {
                    pokemon1.SetActive(false);
                    pokemon2.SetActive(false);
                    pokemon3.SetActive(false);
                }
            }
            break;

            default:
            Debug.Log("Eleccion incorrecta");
            break;
        }
    }
}
