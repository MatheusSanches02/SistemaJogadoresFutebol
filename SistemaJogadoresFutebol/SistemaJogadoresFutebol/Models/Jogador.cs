using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaJogadoresFutebol.Models
{
    public class Jogador
    {
        [HiddenInput]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime Nascimento { get; set; }

        [Display(Name = "Liga Disputada")]
        public string? LigaDisputada { get; set; }
        public bool Lesionado { get; set; }

        [Display(Name = "Posição")]
        public Posicao Posicao { get; set; }
    }

    public enum Posicao
    {
        Goleiro, 
        Defensor,
        [Description("Meio Campo")]
        MeioCampo, 
        Atacante 
    }
}
