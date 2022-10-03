using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SistemaJogadoresFutebol.Models
{
    public class Jogador
    {
        [HiddenInput]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Nacionalidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Liga Disputada")]
        public string? LigaDisputada { get; set; }
        public bool Lesionado { get; set; }

        [Display(Name = "Posição")]
        public Posicao Posicao { get; set; }
    }

    public enum Posicao
    {
        [Display(Name = "Goleiro")]
        Goleiro,
        [Display(Name = "Defensor")]
        Defensor,
        [Display(Name = "Meio Campo")]
        MeioCampo,
        [Display(Name = "Atacante")]
        Atacante 
    }

    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            ?.GetName();
        }
    }
}
